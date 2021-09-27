# ApiRotinaBoleto
API feito para integrar o projeto LeitorArquivoRetorno, onde é feita a leitura e inclusão de novos boletos via API



<h2>Apresentação  :speech_balloon:	</h2> 
Aplicação em .Net Core, para integrar o projeto LeitorArquivoRetorno, integração com aplicação de gerenciamento de pagamentos (boletos), onde por meio da API é possível incluir credor(Pessoa), emitir
boletos (Boleto) bem como a devida leitura dos códigos de barras para identificação dos dados validados.


<h2>Instruções de Uso :blue_book:	</h2>
É necessário efetuar a inclusão de um beneficiário (pessoa) antes da emissão de um novo boleto, isso porque o sistema valida via chave estrangeira, o script para a geração
do banco de dados se encontra na pasta arquivos, atualmente está como SQL Server mas pode ser facilmente adaptada para outro banco de dados.

</br>

![alt text](https://github.com/eltonbrcunha/ApiRotinaBoleto/blob/main/imagens/001.jpg)

![alt text](https://github.com/eltonbrcunha/ApiRotinaBoleto/blob/main/imagens/002.jpg)


<h2>Observações</h2>
Observação Necessário ter um banco de dado SQL configurado para validar a leitura e baixa dos arquivos. Se atentar que há uma <strong>PROCEDURE</strong> responsável pela inclusão das linhas dos arquivos, para teste, que se encontra no script geral do banco de dados.

<h2>Sobre a Tecnologia usada</h2>
:white_check_mark: <strong>Plataforma: ASP.NET Core </strong> </br>
:white_check_mark: <strong>Banco de Dados: SQL Server</strong> </br>

<h2>Conceitos Usados</h2>
- <strong>Padrão REST</strong> </br>
- Arquitetura SOLID </br>
- Design Patterns </br>


<h2>Melhorias a serem feitas</h2>
:exclamation: Criar um gerador automático de códigos de barras</br>

<h2> Desenvolvedor :technologist:</h2>
Elto Brito
Linkedin: (https://www.linkedin.com/in/elton-cunha-87631056)
