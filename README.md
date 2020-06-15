# Sobre o note_app

O note_app é um simples gerenciador de notas feito em **C#** utilizando o entity framework, o projeto foi feito para fins de aprendizado. Conceitos como conexão e permutação do banco de dados foram utilizados de forma prática nessa solução.

# Entidades
O note_app consiste em uma entidade de notas, onde possui a seguinte estrutura:

 - NoteSet
	 - CD_Note : Chave primária da entidade (int)
	 - CH_Name: Nome da nota (string)
	 - CH_Description: Descrição da nota (string)
	 - DT_Date: Data de modificação da nota (DateTime)

# Funções
O note_app consiste em 4 funções, atendendo ao CRUD:

 - Adicionar nova nota
 - Listar notas
 - Editar nota selecionada na tabela
 - Remover nota selecionada na tabela

