
-- create roles table
CREATE TABLE roles (
    role_id INT PRIMARY KEY IDENTITY(1,1),
    name NVARCHAR(50) NOT NULL
);


-- create teams table
CREATE TABLE teams (
    team_id INT PRIMARY KEY IDENTITY(1,1),
    name NVARCHAR(50) NOT NULL
);

GO

-- create users table
CREATE TABLE users (
    user_id INT PRIMARY KEY IDENTITY(1,1),
	first_name nvarchar(50) not null,
	last_name nvarchar(50) not null,
    username NVARCHAR(50) NOT NULL,
    email NVARCHAR(100) NOT NULL,
    password NVARCHAR(100) NOT NULL,
    role_id INT NOT NULL,
    team_id INT NOT NULL,
    CONSTRAINT fk_role
        FOREIGN KEY (role_id)
        REFERENCES roles (role_id),
    CONSTRAINT fk_team
        FOREIGN KEY (team_id)
        REFERENCES teams (team_id)
);
GO

-- create projects table
CREATE TABLE projects (
    project_id INT PRIMARY KEY IDENTITY(1,1),
    name NVARCHAR(100) NOT NULL,
    description NVARCHAR(MAX) NOT NULL,
    deadline DATETIME NOT NULL,
    status NVARCHAR(50) NOT NULL,
    manager_id INT NOT NULL,
    team_id INT NULL,
    CONSTRAINT fk_manager
        FOREIGN KEY (manager_id)
        REFERENCES users (user_id),
    CONSTRAINT fk_project_team
        FOREIGN KEY (team_id)
        REFERENCES teams (team_id)
);


-- create tasks table
CREATE TABLE tasks (
    task_id INT PRIMARY KEY IDENTITY(1,1),
    name NVARCHAR(100) NOT NULL,
    description NVARCHAR(MAX) NOT NULL,
    deadline DATETIME NOT NULL,
    status NVARCHAR(50) NOT NULL,
    user_id INT NOT NULL,
    project_id INT NOT NULL,
    CONSTRAINT fk_user
        FOREIGN KEY (user_id)
        REFERENCES users (user_id),
    CONSTRAINT fk_project
        FOREIGN KEY (project_id)
        REFERENCES projects (project_id)
);


-- create comments table
CREATE TABLE comments (
    comment_id INT PRIMARY KEY IDENTITY(1,1),
    content NVARCHAR(MAX) NOT NULL,
    date DATETIME NOT NULL,
    user_id INT NOT NULL,
    task_id INT NOT NULL,
    CONSTRAINT fk_comment_user
        FOREIGN KEY (user_id)
        REFERENCES users (user_id),
    CONSTRAINT fk_comment_task
        FOREIGN KEY (task_id)
        REFERENCES tasks (task_id)
);

drop table comments;
drop table tasks;
drop table projects;
drop table users;
drop table roles;
drop table teams;



SET IMPLICIT_TRANSACTIONS ON;

insert into roles values('admin');
insert into teams values('admin');

insert into users(first_name, last_name, username, email, password, role_id, team_id) values('admin', 'admin', 'admin', 'admin@gmail.com', 'admin', 1, 1);

insert into roles values('manager');
insert into roles values('employee');
insert into teams values('engineer');

insert into users(first_name, last_name, username, email, password, role_id, team_id) values('John', 'Doe', 'doe', 'doe@gmail.com', 'doe', 2, 2);
insert into users(first_name, last_name, username, email, password, role_id, team_id) values('Adam', 'Smith', 'smith', 'smith@gmail.com', 'smith', 3, 2);

insert into projects(name, description, deadline, status, manager_id, team_id) values('test', 'test', '2023-03-20', 'not done', 2, 2);

insert into tasks(name, description, deadline, status, user_id, project_id) values('task test', 'task test', '2023-03-20', 'not done', 3, 1);
insert into tasks(name, description, deadline, status, user_id, project_id) values('task test2', 'task test2', '2023-04-20', 'not done', 3, 1);
insert into tasks(name, description, deadline, status, user_id, project_id) values('task test3', 'task tes3t', '2023-05-20', 'not done', 3, 1);


begin transaction;
insert into tasks(name, description, deadline, status, user_id, project_id) values('doe', 'task tes3t', '2023-05-20', 'not done', 2, 1);
insert into tasks(name, description, deadline, status, user_id, project_id) values('doe', 'task tes3t', '2023-05-20', 'not done', 2, 1);
commit;

begin transaction;
update tasks set status = 'not done';
commit;

select * from projects;
select * from users;

select * from tasks inner join users on users.user_id = tasks.user_id;

select * from users where team_id = 2;
select * from roles;

insert into comments (content, date, user_id, task_id) values('test', getdate(), 2, 6);


SELECT count(*) FROM tasks where status = 'not done' and user_id = 2;