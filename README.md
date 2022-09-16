![image](https://user-images.githubusercontent.com/98191980/190448587-b1e8c8b7-09a9-46ff-bd48-61739d1f7836.png)

<img src="https://img.shields.io/static/v1?label=by&message=Alura&color=blue&style=for-the-badge"> <img src="https://img.shields.io/static/v1?label=Tech&message=.NET 6.0&color=9ceb7d&style=for-the-badge&logo=.NET"> <img src="https://img.shields.io/static/v1?label=Tech&message=C%23&color=9ceb7d&style=for-the-badge&logo=csharp"> <img src="https://img.shields.io/static/v1?label=Tech&message=Drawio&color=9ceb7d&style=for-the-badge">

### Diagrama de classes

![DiagramasDeClasses drawio](https://user-images.githubusercontent.com/98191980/190630701-ccf4d138-e17d-41bf-822b-74f41f526871.png)

### Orientação a objetos com C#

- Sobrecarga de métodos é uma forma de termos mais de um método com o mesmo nome em nosso código. O que vai diferenciá-los é o tipo e quantidade de parâmetros recebidos. Com ela conseguimos aplicar o conceito de polimorfismo, no qual um comportamento responde de maneira diferente de acordo com os dados informados em sua chamada.
- Usamos o operador this para trabalhar com elementos da própria instância do objeto.
- Vimos boas práticas na organização de projetos como a organização dos arquivos em diretórios distintos, que irão facilitar futuras manutenções e até no entendimento do projeto com base em suas responsabilidades.

### Entendendo herança

- Na orientação a objetos, a herança é um mecanismo que nos permite reaproveitar código.
- Podemos redefinir um comportamento escrito em uma classe base em uma classe derivada. Assim, ele passará a funcionar de forma específica em uma classe derivada.
- Acessamos definições presentes na classe base usando o operador base.

### Usando classes abstratas

- Invocamos o construtor da classe base, a partir do construtor da classe derivada.
- Protegemos propriedades usando o operador de visibilidade protected para impedir o acesso direto a uma propriedade de um objeto.
- Utilizamos classes abstratas para definir uma classe que será modelo para criação de novas classes.
- Como usar métodos abstratos para definir como obrigatória a implementação de determinado comportamento em classes derivadas.

### Mais sobre heranças

- Como adicionar uma nova classe à hierarquia de classes já definida com a intenção de atender a uma nova demanda do projeto.
- Avançamos na utilização da herança de classes fazendo uma classe herdar de outra.

### Trabalhando com interfaces

- O C# não implementa o conceito de herança múltipla, pois classes muito distintas com métodos de mesmo nome poderiam causar problemas para o compilador definir qual usar na nova instância.
- O funcionamento das interfaces na orientação a objetos, que são contratos que definem comportamentos a serem implementados pelas classes que assinam este contrato.
- Como utilizar o padrão de nomenclatura adotada para nomeação de interfaces, aplicando a convenção que utiliza o prefixo I.
