using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SQLite;
using System.Threading.Tasks;

namespace TestTask
{
    public static class SqlText
    {
        public static List<string> ListSelect = new List<string>();
        public static void FillListSelect()
        {
            // Все сотрудники
            ListSelect.Add(@"SELECT e.id,e.name,e.salary,e.chief_id, chief.name chief,e.department_id,d.name Department 
                            FROM employee e
                            LEFT JOIN department d
                            ON e.department_id = d.id
                            LEFT JOIN employee chief
                            ON e.chief_id = chief.id");

            // 1.1 Суммарная зарплата по отделам с руководителями
            ListSelect.Add(@"SELECT   idDep,nameDep, sum(salary) sumS
                            FROM 
                            (--  руководящие сотрудники и id отделов, которыми они руководят
                            SELECT DISTINCT d.id idDep,d.name nameDep,e.id,e.salary 
                            FROM employee e 
                            INNER JOIN employee ee 
                            ON e.id = ee.chief_id
                            INNER JOIN department d
                            ON d.id = ee.department_id
                            WHERE e.id in(SELECT DISTINCT chief_id FROM employee WHERE chief_id IS NOT NULL)  
                            UNION ALL -- не руководящие сотрудники
                            SELECT department_id, dep.name,emp.id,salary FROM employee emp
                            LEFT JOIN department dep
                            ON dep.id = emp.department_id
                            WHERE emp.id NOT IN (SELECT DISTINCT chief_id FROM employee WHERE chief_id IS NOT NULL)
                            UNION ALL -- сотрудники 3 отдела без начальника
                            SELECT department_id, dep.name,emp.id,salary FROM employee emp
                            LEFT JOIN department dep
                            ON dep.id = emp.department_id
                            WHERE emp.department_id IN (SELECT DISTINCT department_id FROM employee WHERE chief_id IS NULL)
                            AND chief_id IS NOT NULL
                            ) x group by  idDep");

            // 1.2 Суммарная зарплата по отделам без руководителей
            ListSelect.Add(@"SELECT  department_id idDep,d.name nameDep, sum(salary) sumS
                           FROM employee e
                           LEFT JOIN department d
                           ON e.department_id = d.id
                           WHERE e.id NOT IN (SELECT DISTINCT chief_id FROM employee WHERE chief_id IS NOT NULL )
                           group by department_id  
                           UNION ALL
                           SELECT  department_id idDep,d.name nameDep, sum(salary) sumS
                           FROM employee e
                           LEFT JOIN department d
                           ON e.department_id = d.id
                           WHERE department_id = (SELECT DISTINCT department_id FROM employee WHERE chief_id IS NULL)
                           AND e.id NOT IN (SELECT id FROM employee WHERE chief_id is NULL)");

            // 2. Отдел, в котором у сотрудника (где он не руководит) зарплата максимальная
            ListSelect.Add(@"SELECT id,name,maxsalary FROM department
                           INNER JOIN (SELECT max(salary) maxsalary,department_id FROM employee 
                           WHERE chief_id IS NOT NULL) d
                           ON department.id = d.department_id");

            // 3. Зарплаты руководителей департаментов по убыванию
            ListSelect.Add(@"SELECT  DISTINCT d.id idDep,d.name nameDep,e.id,e.name,e.salary 
                             FROM employee e 
                             INNER JOIN employee ee 
                             ON e.id = ee.chief_id
                             INNER JOIN department d
                             ON d.id = ee.department_id
                             WHERE e.id in(
                             SELECT DISTINCT chief_id FROM employee WHERE chief_id IS NOT NULL)
                             order by e.salary desc");

        }
    }
}
