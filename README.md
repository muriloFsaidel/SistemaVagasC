# SistemaVagasC

## [PT-BR]

Sistema de cadastro, consulta e alteração de vagas em tempo de execução, usando banco de dados local Sql Server.

Passos para executá-lo:

Crie um projeto no visual studio e inclua estes formulários;
Crie um item de banco de dado sql (Service-based Database);
Em server explorer (explorador de servidor);
Abra conexões de dados ( Data Connections);
Botão direito no diretório tables (tabelas), escolha add new table ou new query e crie tabela de vagas executando o script abaixo:
create table vaga(
     id INT NOT NULL IDENTITY(1,1) PRIMARY KEY,
     nome VARCHAR(40) NOT NULL UNIQUE,
     faixa_salarial VARCHAR(60) NOT NULL,
     requisitos VARCHAR(400) NOT NULL,
     escolaridade_minima VARCHAR(70) NOT NULL,
     email_empresa VARCHAR(100)
 );.
 
 
Por fim , preencha a variável caminhoBanco nos formulários com valor da propriedade ConnectionString do banco de dados criado (server explorer-> data connections -> clique no nome do banco de dados criado -> canto inferior direito).

## [ENGLISH]

System for registering, consulting and changing vacancies at runtime, using a local Sql Server database.

Steps to execute it:

Create a project in Visual Studio and include these forms;
Create a SQL database item (Service-based Database);
In Server Explorer;
Open Data Connections;
Right-click on the tables directory, choose Add New Table or New Query and create a vacancy table by running the script below:
create table vacancy(
id INT NOT NULL IDENTITY(1,1) PRIMARY KEY,
name VARCHAR(40) NOT NULL UNIQUE,
salary_range VARCHAR(60) NOT NULL,
requirements VARCHAR(400) NOT NULL,
minimum_education VARCHAR(70) NOT NULL,
company_email VARCHAR(100)
);.

Finally, fill in the pathBank variable in the forms with the value of the ConnectionString property of the created database (server explorer-> data connections -> click on the name of the created database -> bottom right corner).
