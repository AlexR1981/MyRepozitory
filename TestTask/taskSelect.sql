-- Все сотрудники с отделами и зарплатами
SELECT e.id,e.name,e.salary,e.chief_id, chief.name chief,e.department_id,d.name 
FROM employee e
LEFT JOIN department d
ON e.department_id = d.id
LEFT JOIN employee chief
ON e.chief_id = chief.id
-- 1.1 Суммарная зарплата по отделам с руководителями
SELECT   idDep,nameDep, sum(salary) sumS
  FROM 
  (--  руководящие сотрудники и id отделов, которыми они руководят
  select distinct d.id idDep,d.name nameDep,e.id,e.salary 
  from employee e 
  inner join employee ee 
  on e.id = ee.chief_id
  inner join department d
  on d.id = ee.department_id
  where e.id in(select distinct chief_id from employee where chief_id is not null)  
  UNION ALL -- не руководящие сотрудники
  select department_id, dep.name,emp.id,salary from employee emp
  left join department dep
  on dep.id = emp.department_id
  where emp.id not in (select distinct chief_id from employee where chief_id is not null)
  UNION ALL -- сотрудники 3 отдела без начальника
  select department_id, dep.name,emp.id,salary from employee emp
  left join department dep
  on dep.id = emp.department_id
  where emp.department_id in (select distinct department_id from employee where chief_id is null)
  and chief_id is not null
) x
 group by  idDep
 

--where e.id in (select distinct chief_id from employee)


-- 1.2 Суммарная зарплата по отделам без руководителей
SELECT  department_id idDep,d.name nameDep, sum(salary) sumS
  FROM employee e
  left join department d
  on e.department_id = d.id
  WHERE e.id not in (select distinct chief_id from employee where chief_id is not null )
  group by department_id  
UNION ALL
SELECT  department_id idDep,d.name nameDep, sum(salary) sumS
  FROM employee e
  left join department d
  on e.department_id = d.id
  WHERE department_id = (select distinct department_id from employee where chief_id is null)
  and e.id not in (select id from employee where chief_id is null)
    
-- 2. Отдел, в котором у сотрудника (где он не руководит) зарплата максимальная
select id,name,maxsalary from department
inner join (select max(salary) maxsalary,department_id from employee 
where chief_id is not null) d
on department.id = d.department_id

-- 3. Зарплаты руководителей департаментов по убыванию
select  distinct d.id idDep,d.name nameDep,e.id,e.name,e.salary 
from employee e 
inner join employee ee 
on e.id = ee.chief_id
inner join department d
on d.id = ee.department_id
where e.id in(
  select distinct chief_id from employee where chief_id is not null)
  order by e.salary desc
  
