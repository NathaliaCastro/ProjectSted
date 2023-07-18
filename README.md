<div align=center>

   💻 **Veja o projeto em produção [aqui](https://1drv.ms/u/s!ApwTC-vkpnN9f_MPh18ir_XXMDY?e=6lJu2V)**
   
</div>

<br>
<br>

##Especificações Técnicadas no diretório
- \ProjectSiteWare\Documentation

## Recursos de Usuário

- Página de detalhes de produto
- Carrinho de compras (Adicionar ou remover produtos, cálculo de frete), necessário registro para acessar
- Cadastrar contas / Login
- Perfil (Trocar senha, username)

## Como usar?

### Pré-requisitos

- Necessário instalar a versão mais recente do Visual Studio Community 2022;
- Versão mais recente (ou a mais estável) do .NET 6;
- Entity Framework Core 6

### Instalação
Siga os passos abaixo para ter acesso ao seu ambiente de desenvolvimento:

1. Clone o repositório:
```csharp
   git clone https://github.com/GabrielFSouza/ProjectSiteWare.git
```

2. Criar conexao com o banco de dados pelo Visual Studio(**OPCIONAL**): 
	- SQL Server Object Explorer > SQL Server > Databases 
    - Clicar com o Botão direito em cima de Database e selecionar **ADD New Database** coloque o nome **DDD_ECOMMERCE**

3. Configure a string de conexão no arquivo **appsettings.json** apontando para o seu banco de dados SQL Server **caso voce tenha colocado outro nome**;

4. Para criar o banco de dados SQL Server e suas respectivas tabelas, abra o **Package Manager Console** em seu Visual Studio e digite os comandos: 
    - Criação das tabelas do Identity: Abra o Console do Gerenciador de Pacotes > **Acima em Projeto padrão**: Selecione **Infrastructure**. Execute os comandos abaixo:
        ```csharp
            Add-Migration InitialCreate -Context ContextBase
        ```

    - Criação das tabelas da camada de negócios: 
        ```csharp
            Update-Database -Context ContextBase
        ```

5. Pressione `F5 ou Ctrl+F5` para rodar o projeto no seu navegador.
