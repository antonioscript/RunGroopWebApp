# Grupos de Corrida
Trata-se de um software que apresenta grupos de corridas e maratonas para corredores, além de pode cadastrar suas próprias corridas

## Demonstração em Vídeo (clique no botão abaixo para visualizar)
[<img src="https://img.shields.io/badge/YouTube-FF0000?style=for-the-badge&logo=youtube&logoColor=white">](https://www.youtube.com/watch?v=lNDGkLJH2nc&t=78s)

## Tecnologias Utilizadas
- Linguagem C# 
- .NET 6
- ASP .NET Core (Modelo MVC)
- Razor Pages
- Entity Framework Core
- Banco de Dados SQL Server

## Objetivo do Sistema
A aplicação foi pensada em uma solução que simula uma comunidade de corredores, onde o usuário pode encontrar grupos de corrida e maratonas. Além de pode cadastrar seus próprios grupos ou maratonas. 

Os grupos de corrida são formados por uma pequena quantidade de pessoas que se encontram com frequência em um parque ou em uma rua, por exemplo. Enquanto que as corridas são as maratonas ou corridas específicas organizadas em forma de eventos e envolve um número muito maior de pessoas.

Com esse tipo de sistema fica mais fácil encontrar as atividades físicas e se conectar com pessoas do mesmo interesse em comum. 

## Tela Inicial
![image](https://user-images.githubusercontent.com/10932478/185006360-5e90e8ac-ffdd-4cb9-8742-107bbede9ad1.png)
Essa é a tela inicial da aplicação. O usuário pode clicar tanto nos botões de "Encontre um Clube", "Encontre uma Corrida" ou "Comece Agora"

## Página de Clubes
![image](https://user-images.githubusercontent.com/10932478/185006553-4cb1145d-061f-42ac-b9ff-177a80c75a06.png)
Na página de clubes, o usuário tem acesso a todos os clubes que estão cadastrados naquele momento

## Página de Corridas
![image](https://user-images.githubusercontent.com/10932478/185006596-a28455cf-f0ee-41bf-9daa-663509ab4754.png)
De forma semelhante, na página de corridas o usuário tem acesso a todas as corridas

## Página de Cadastro
![image](https://user-images.githubusercontent.com/10932478/185006639-793afb84-81f0-4a15-bed0-bfc27cdaf625.png)
Ao clicar em "Cadastrar Nova Corrida"  o usuário é capaz de cadastrar uma nova corrida, preenchendo as informações de Título, Descrição, Categoria, Endereço, além de ter a opção de fazer o upload de alguma imagem. Ao clicar em "Enviar", todas as informações são gravadas no banco de dados SQL Server

## Exemplo de Cadastro
![image](https://user-images.githubusercontent.com/10932478/185006662-e2ed2e17-fa0a-4195-9802-ec7b432382ae.png)
Ao preencher as informações, na parte de categoria, o usuário pode escolher uma das cinco categorias apresentadas: Marathon, Ultra, FiveK, TenK, Half Marathon.

## Corridas Cadastradas
![image](https://user-images.githubusercontent.com/10932478/185006694-38d1f3f0-15b9-4fdd-9194-2acc73bb3eb0.png)
Ao cadastrar uma nova corrida, a informação daquele cadastro é carregada na tela inicial da página de corridas.

## Página de Edição
![image](https://user-images.githubusercontent.com/10932478/185006736-f5f6fe16-f927-43a1-bbc5-1e6b0a96a06b.png)
Na página de edição, o usuário tem a possibilidade de alterar ou modificar alguma informação, inclusive escolher uma nova imagem para upload.

## Página de Detalhes
![image](https://user-images.githubusercontent.com/10932478/185006941-e08c56ae-b0c3-4d00-9709-8fb317cd59be.png)
Clicando em "Visualizar", todas as informações são carregadas e agrupadas de uma forma mais fácil de serem visualizadas.

## Página de Remoção
![image](https://user-images.githubusercontent.com/10932478/185006968-75b9a7a3-7004-4cf8-afb8-c102f75a513d.png)
E clicando em "Excluir", todas as informações daquela corrida são deletadas do banco de dados

## Página de Clubes
![image](https://user-images.githubusercontent.com/10932478/185007003-6c7e61b6-8581-4370-8552-cb3854565a13.png)
E de forma semelhante, todas as funcionalidades da página de corrida se aplicam à página de clubes





