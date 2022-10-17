using Xunit;
using System.IO;
using System;
using Moq;
using guessing_number;
using FluentAssertions;

namespace guessing_number.Test;

[Collection("Sequential")]
public class TestThirdReq
{
    [Theory(DisplayName = "Deve receber a executar o fluxo completo do programa")]
    [InlineData(new object[] {new string[]{"10"}, 10})]
    public void TestFullFlow(string[] entrys, int mockValue)
    {
        string stringReaderEntry = "";

        foreach (var entry in entrys)
        {
            stringReaderEntry += entry + "\n";
        }

        Mock<IRandomGenerator> getInt = new();
        getInt.Setup(instance => instance.GetInt(It.IsAny<int>(), It.IsAny<int>())).Returns(mockValue);
        GuessNumber instance = new(getInt.Object);

        string[] consoleResponse;

        using(var stringWriter = new StringWriter())
        {
            using(var stringReader = new StringReader(stringReaderEntry))
            {
                Console.SetOut(stringWriter);
                Console.SetIn(stringReader);
                instance.Greet();
                instance.RandomNumber();
                
                do
                {
                    instance.ChooseNumber();
                    instance.AnalyzePlay();
                } while (instance.userValue != instance.randomValue);
                consoleResponse = stringWriter.ToString().Trim().Split("\n");
            }
            instance.userValue.Should().Be(mockValue);
            consoleResponse[^1].Should().Contain("ACERTOU!");
        };
    }
}