# SistemaVagasC
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

