using Xunit;
using System.IO;
using System;
using guessing_number;
using FluentAssertions;

namespace guessing_number.Test;

[Collection("Sequential")]
public class TestFirstReq
{
    [Theory(DisplayName = "Deve exibir mensagem inicial!")]
    [InlineData(new object[] {new string[]{"---Bem-vindo ao Guessing Game---", "Para começar, tente adivinhar o número que eu pensei, entre -100 e 100!"}})]
    public void TestPrintInitialMessage(string[] expected)
    {
        GuessNumber instance = new();
        string[] consoleResponse;
        using(var stringWriter = new StringWriter()) 
        {
            Console.SetOut(stringWriter);
            instance.Greet();
            consoleResponse = stringWriter.ToString().Trim().Split('\n');
        }
        consoleResponse.Should().BeEquivalentTo(expected);                                              
    }

    [Theory(DisplayName = "Deve receber a entrada do usuário e converter para int")]
    [InlineData("0", 0)]
    public void TestReceiveUserInputAndConvert(string entry, int expected)
    {        
        GuessNumber instance = new();
        using(var stringWriter = new StringWriter())
        {
            using(var stringReader = new StringReader(entry))
            {
                Console.SetOut(stringWriter);
                Console.SetIn(stringReader);

                instance.ChooseNumber();                
            }
            instance.userValue.Should().Be(expected);
        };
    }

    [Theory(DisplayName = "Deve receber a entrada do usuário e garantir que é um numérico")]
    [InlineData(new object[] {new string[]{"10,", "10"}, 10})]
    public void TestReceiveUserInputAndVerifyType(string[] entrys, int expected)
    {
        string stringReaderEntry = "";

        foreach (var entry in entrys)
        {
            stringReaderEntry += entry + "\n";
        }

        GuessNumber instance = new();
        using(var stringWriter = new StringWriter())
        {
            using(var stringReader = new StringReader(stringReaderEntry))
            {
                Console.SetOut(stringWriter);
                Console.SetIn(stringReader);

                instance.ChooseNumber();                
            }
            instance.userValue.Should().Be(expected);
        };
    }

    [Theory(DisplayName = "Deve receber a entrada do usuário e garantir que está entre -100 e 100!")]
    [InlineData(new object[] {new string[]{"1000", "10"}, 10})]
    public void TestReceiveUserInputAndVerifyRange(string[] entrys, int expected)
    {
        string stringReaderEntry = "";

        foreach (var entry in entrys)
        {
            stringReaderEntry += entry + "\n";
        }

        GuessNumber instance = new();
        using(var stringWriter = new StringWriter())
        {
            using(var stringReader = new StringReader(stringReaderEntry))
            {
                Console.SetOut(stringWriter);
                Console.SetIn(stringReader);

                instance.ChooseNumber();                
            }
            instance.userValue.Should().Be(expected);
        };
    }    
}