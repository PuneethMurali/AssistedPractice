insert into Classes4(ClassName) values ('Class A');
INSERT INTO Classes4(ClassName) VALUES ('Class B');


INSERT INTO Subjects4 (SubjectName) VALUES ('Mathematics');
INSERT INTO Subjects4 (SubjectName) VALUES ('Science');


INSERT INTO Students4 (FirstName, LastName, DateofBirth, ClassID) VALUES ('Raju', 'Murugan', '2000-01-15', 1);
INSERT INTO Students4 (FirstName, LastName, DateofBirth, ClassID) VALUES ('Vetri', 'Vel', '2000-03-22', 2);

select * from Classes4;
select * from Subjects4;
select * from Students4;