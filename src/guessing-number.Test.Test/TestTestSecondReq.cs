using Xunit;
using System;
using FluentAssertions;

namespace guessing_number.Test.Test;

[Collection("Sequential")]
public class TestRandomlyChooseANumberSuccess
{
    [Trait("Category", "9 - Criou testes de sucesso para o TestRandomlyChooseANumber.")]
    [Theory(DisplayName = "TestRandomlyChooseANumber deve ser executado com sucesso com a entrada correta")]
    [InlineData(-100, 100)]
    public void TestSucessTestRandomlyChooseANumber(int MinimumRange, int MaximumRange)
    {
        TestSecondReq instance = new();
        Action act = () => instance.TestRandomlyChooseANumber(MinimumRange, MaximumRange);
        act.Should().NotThrow<Xunit.Sdk.XunitException>();
        act.Should().NotThrow<NotImplementedException>();
    }
}

[Collection("Sequential")]
public class TestRandomlyChooseANumberFail
{
    [Trait("Category", "10 - Criou testes de falha para o TestRandomlyChooseANumber.")]
    [Theory(DisplayName = "TestRandomlyChooseANumber deve falhar com a entrada errada")]
    [InlineData(101, 200)]
    [InlineData(200, 100)]
    [InlineData(-101, -200)]
    [InlineData(1000, 2000)]
    public void TestFailTestPrintInitialMessage(int MinimumRange, int MaximumRange)
    {
        TestSecondReq instance = new();
        Action act = () => instance.TestRandomlyChooseANumber(MinimumRange, MaximumRange);
        act.Should().Throw<Xunit.Sdk.XunitException>();
        act.Should().NotThrow<NotImplementedException>();
    }
}

[Collection("Sequential")]
public class TestProgramComparisonValuesLessSuccess
{
    [Trait("Category", "11 - Criou testes de sucesso para o TestProgramComparisonValuesLess.")]
    [Theory(DisplayName = "TestProgramComparisonValuesLess deve ser executado com sucesso com a entrada correta")]
    [InlineData(50, 30)]
    [InlineData(50, 10)]
    [InlineData(50, -100)]
    [InlineData(50, 49)]
    [InlineData(50, 0)]
    public void TestSucessTestProgramComparisonValuesLess(int mockValue, int entry)
    {
        TestSecondReq instance = new();
        Action act = () => instance.TestProgramComparisonValuesLess(mockValue, entry);
        act.Should().NotThrow<Xunit.Sdk.XunitException>();
        act.Should().NotThrow<NotImplementedException>();
    }
}

[Collection("Sequential")]
public class TestProgramComparisonValuesLessFail
{
    [Trait("Category", "12 - Criou testes de falha para o TestProgramComparisonValuesLess.")]
    [Theory(DisplayName = "TestProgramComparisonValuesLess deve falhar com a entrada errada")]
    [InlineData(50, 50)]
    [InlineData(50, 100)]
    [InlineData(50, 51)]
    [InlineData(50, 99)]
    [InlineData(50, 77)]
    public void TestFailTestProgramComparisonValuesLess(int mockValue, int entry)
    {
        TestSecondReq instance = new();
        Action act = () => instance.TestProgramComparisonValuesLess(mockValue, entry);
        act.Should().Throw<Xunit.Sdk.XunitException>();
        act.Should().NotThrow<NotImplementedException>();
    }
}

[Collection("Sequential")]
public class TestProgramComparisonValuesBiggerSuccess
{
    [Trait("Category", "13 - Criou testes de sucesso para o TestProgramComparisonValuesBigger.")]
    [Theory(DisplayName = "TestProgramComparisonValuesBigger deve ser executado com sucesso com a entrada correta")]
    [InlineData(50, 60)]
    [InlineData(50, 90)]
    [InlineData(50, 100)]
    [InlineData(50, 51)]
    [InlineData(50, 77)]
    public void TestSucessTestProgramComparisonValuesBigger(int mockValue, int entry)
    {
        TestSecondReq instance = new();
        Action act = () => instance.TestProgramComparisonValuesBigger(mockValue, entry);
        act.Should().NotThrow<Xunit.Sdk.XunitException>();
        act.Should().NotThrow<NotImplementedException>();
    }
}

[Collection("Sequential")]
public class TestProgramComparisonValuesBiggerFail
{
    [Trait("Category", "14 - Criou testes de falha para o TestProgramComparisonValuesBigger.")]
    [Theory(DisplayName = "TestProgramComparisonValuesBigger deve falhar com a entrada errada")]
    [InlineData(50, 49)]
    [InlineData(50, -50)]
    [InlineData(50, 0)]
    [InlineData(50, 1)]
    [InlineData(50, -100)]
    public void TestFailTestProgramComparisonValuesBigger(int mockValue, int entry)
    {
        TestSecondReq instance = new();
        Action act = () => instance.TestProgramComparisonValuesBigger(mockValue, entry);
        act.Should().Throw<Xunit.Sdk.XunitException>();
        act.Should().NotThrow<NotImplementedException>();
    }
}

[Collection("Sequential")]
public class TestProgramComparisonValuesEqualSuccess
{
    [Trait("Category", "15 - Criou testes de sucesso para o TestProgramComparisonValuesEqual.")]
    [Theory(DisplayName = "TestProgramComparisonValuesEqual deve ser executado com sucesso com a entrada correta")]
    [InlineData(50, 50)]
    [InlineData(100, 100)]
    [InlineData(-99, -99)]
    [InlineData(0, 0)]
    [InlineData(77, 77)]
    public void TestSucessTestProgramComparisonValuesEqual(int mockValue, int entry)
    {
        TestSecondReq instance = new();
        Action act = () => instance.TestProgramComparisonValuesEqual(mockValue, entry);
        act.Should().NotThrow<Xunit.Sdk.XunitException>();
        act.Should().NotThrow<NotImplementedException>();
    }
}

[Collection("Sequential")]
public class TestProgramComparisonValuesEqualFail
{
    [Trait("Category", "16 - Criou testes de falha para o TestProgramComparisonValuesEqual.")]
    [Theory(DisplayName = "TestProgramComparisonValuesEqual deve falhar com a entrada errada")]
    [InlineData(50, -50)]
    [InlineData(100, -100)]
    [InlineData(-99, 0)]
    [InlineData(0, -99)]
    [InlineData(77, 0)]
    public void TestFailTestProgramComparisonValuesEqual(int mockValue, int entry)
    {
        TestSecondReq instance = new();
        Action act = () => instance.TestProgramComparisonValuesEqual(mockValue, entry);
        act.Should().Throw<Xunit.Sdk.XunitException>();
        act.Should().NotThrow<NotImplementedException>();
    }

}