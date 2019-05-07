----create database CsharpProje

--create table Teachers(
--ID int primary key identity(10000,1),
--Tname nvarchar(200),
--Tsurname nvarchar(200),
--Tparol nvarchar(100)
--)

--create table Groups(
--ID int primary key identity,
--Gname nvarchar(100)

--)

----create table Point(
----ID int primary key identity,
----PointRes  nvarchar(50)
----)
--create table Students(
--ID int primary key identity(100000,1) ,
--Sname nvarchar(200),
--Ssurname nvarchar(200),
--Sparol nvarchar(100),
--GroupId int references Groups(Id)
--)

--create table Subjects(
--ID int primary key identity,
--Subjname nvarchar(100)
--)

--create table TSG(
--ID int primary key identity,
--TeacherID int references Teachers(Id),
--GroupId int references Groups(ID),
--SubjectId int references Subjects(ID)
--)

--create table Grade(
--ID int primary key identity ,
--SubjectID int references Subjects(Id),
--StudentID int references Students(ID),
--Point int   references Point(ID)

--)


--create table Evaluation(
--ID int primary key identity,
--SubjectId int references Subjects(ID),
--BeforeExam int,
--AfterExam int,
--StudentID int references Students(Id)

--)


--create table Question(
--ID int primary key identity ,
--MainQuest nvarchar(200),
--AnswerA nvarchar (100),
--AnswerB nvarchar (100),
--AnswerC nvarchar (100),
--AnswerD nvarchar (100),
--SubjectId int references Subjects(Id)
--)
