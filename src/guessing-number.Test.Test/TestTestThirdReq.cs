using Xunit;
using System;
using FluentAssertions;

namespace guessing_number.Test.Test;

[Collection("Sequential")]
public class TestFullFlowSuccess
{
    [Trait("Category", "17 - Criou testes de sucesso para o TestFullFlow.")]
    [Theory(DisplayName = "TestFullFlow deve ser executado com sucesso com a entrada correta")]
    [InlineData(new object[] {new string[]{"10"}, 10})]
    [InlineData(new object[] {new string[]{"100", "0"}, 0})]
    [InlineData(new object[] {new string[]{"-99", "-10", "77"}, 77})]
    [InlineData(new object[] {new string[]{"teste", "15"}, 15})]
    [InlineData(new object[] {new string[]{"10", "teste", "29"}, 29})]
    public void TestSucessTestFullFlow(string[] entrys, int mockValue)
    {
        TestThirdReq instance = new();
        Action act = () => instance.TestFullFlow(entrys, mockValue);
        act.Should().NotThrow<Xunit.Sdk.XunitException>();
        act.Should().NotThrow<NotImplementedException>();
    }
}

[Collection("Sequential")]
public class TestFullFlowFail
{
    [Trait("Category", "18 - Criou testes de falha para o TestFullFlow.")]
    [Theory(DisplayName = "TestFullFlow deve falhar com a entrada errada")]
    [InlineData(new object[] {new string[]{"10"}, -10})]    
    public void TestFailTestFullFlow(string[] entrys, int mockValue)
    {
        TestThirdReq instance = new();
        Action act = () => instance.TestFullFlow(entrys, mockValue);
        act.Should().Throw<System.OutOfMemoryException>();
        act.Should().NotThrow<NotImplementedException>();
    }
}