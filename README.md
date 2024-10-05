# GravatarDW

[![Licença](https://img.shields.io/badge/license-MIT-blue.svg)](https://github.com/davidwallacem1982/GravatarDW/blob/main/LICENSE)
[![Status do Build](https://img.shields.io/badge/build-passing-brightgreen.svg)](https://github.com/davidwallacem1982/GravatarDW/actions)
[![NuGet](https://img.shields.io/nuget/v/GravatarDw.svg)](https://www.nuget.org/packages/GravatarDw)

**GravatarDW** é uma extensão .NET que gera URLs do Gravatar com base em endereços de e-mail. Esta biblioteca simplifica o processo de criação de links para o Gravatar, usados frequentemente para exibir fotos de perfil associadas ao e-mail de um usuário.

## Funcionalidades

- Método de extensão simples para converter um e-mail em uma URL do Gravatar.
- Tamanho de imagem personalizável.
- Integração fácil com qualquer projeto .NET.
- Leve e de alto desempenho.

## Tabela de Conteúdos
- [Instalação](#instalação)
- [Uso](#uso)
- [Testes](#testes)
- [Contribuindo](#contribuindo)
- [Licença](#licença)

## Instalação

Você pode instalar a biblioteca **GravatarDW** via [NuGet](https://www.nuget.org/packages/GravatarDw).

Use o seguinte comando no seu projeto .NET:

```bash
dotnet add package GravatarDw
```
Ou via o Gerenciador de Pacotes NuGet no Visual Studio:

- Vá em **Ferramentas** > **Gerenciador de Pacotes NuGet** > **Gerenciar Pacotes NuGet para a Solução**.
- Pesquise por **GravatarDw** e instale o pacote.

## Uso
Uma vez instalado, você pode utilizar o método de extensão ToGravatar para gerar uma URL do Gravatar a partir de um endereço de e-mail.

Exemplo

```bash
using System;
using Gravatar;

class Program
{
    static void Main()
    {
        string email = "davidwallacem@hotmail.com";
        int tamanho = 200; // Opcional: o padrão é 50px
        string urlGravatar = email.ToGravatar(tamanho);
        
        Console.WriteLine(urlGravatar);
        // Saída: https://www.gravatar.com/avatar/a042db3d80d46a527f8ba1605a74be57?s=200
    }
}
```
## Assinatura do Método
```bash
public static string ToGravatar(this string email, int tamanho = 50)
```
- email: O endereço de e-mail do usuário.
- tamanho (opcional): O tamanho da imagem do Gravatar (o padrão é 50px).

## Formato da URL do Gravatar

A URL gerada segue o formato padrão do Gravatar:

```bash
https://www.gravatar.com/avatar/{hash}?s={tamanho}
```

- hash: Hash MD5 do endereço de e-mail.
- tamanho: O tamanho da imagem solicitada em pixels.

## Testes
O projeto inclui testes unitários para garantir o comportamento correto do método de extensão Gravatar.

## Executando os Testes

Se você deseja executar os testes localmente, use o seguinte comando:
```bash
dotnet test
```

Isso irá executar todos os testes unitários definidos no projeto **Gravatar.Tests** usando o MSTest.

## Exemplo de Teste
```bash
[TestMethod]
[DataRow("davidwallacem@hotmail.com", 200, true)]
[DataRow("", 200, false)]
public void ShouldValidateGravatar(string email, int? tamanho, bool status)
{
    var result = email.ToGravatar(tamanho ?? 50);
    Assert.AreEqual((result != string.Empty), status);
}
```

## Cobertura de Código

O projeto também inclui o Coverlet para medir a cobertura de código. Use o seguinte comando para gerar um relatório de cobertura:
```bash
dotnet test /p:CollectCoverage=true
```

## Contribuindo

Contribuições são bem-vindas! Se você deseja contribuir para este projeto, siga os passos abaixo:

- Faça um fork do repositório.
- Crie uma nova branch com um nome descritivo (ex: feature/adicionar-nova-funcionalidade).
- Faça suas alterações.
- Submeta um pull request.
- Certifique-se de que todos os testes estão passando e que a cobertura é mantida para novas funcionalidades.

<h2 id="license">License 📃 </h2>

Este projeto é licenciado sob a licença MIT. Consulte o arquivo [MIT](./LICENSE) para mais detalhes.

## Informações do Repositório

- Autor: [**David Wallace Marques Ferreira**](https://www.linkedin.com/in/david-wallace-marques-ferreira/) 
- Empresa: dw.io
- URL do Projeto: - [**https://github.com/davidwallacem1982/GravatarDW**](https://github.com/davidwallacem1982/GravatarDW) 
- Licença: Licença MIT
- Pacote NuGet: GravatarDw
