namespace V2
{
    public class UnitTest1
    {
        public static TheoryData<Guid> Data => new TheoryData<Guid>
        {
            Guid.NewGuid(),
            Guid.NewGuid()
        };


        [Theory]
        [MemberData(nameof(Data))]
        public void Test1(Guid id)
        {
            Assert.True(true);
        }

    }
}
