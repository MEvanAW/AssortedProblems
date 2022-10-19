using TreeDictionary;

namespace AssortedProblemsTests
{
    public class TreeDictionaryTest
    {
        private readonly Tree tree = new(
            new Tree(
                new Tree(
                    null,
                    'd',
                    null),
                'd',
                new Tree(
                    new Tree(
                        new Tree(
                            null,
                            'y',
                            null),
                        'l',
                        new Tree(
                            new Tree(
                                new Tree(
                                    null,
                                    'r',
                                    null),
                                'e',
                                null),
                            't',
                            null)),
                    'l',
                    null)),
            'a',
            new Tree(
                new Tree(
                    new Tree(
                        new Tree(
                            null,
                            'e',
                            null),
                        'd',
                        null),
                    'o',
                    null),
                'c',
                new Tree(
                    new Tree(
                        new Tree(
                            new Tree(
                                new Tree(
                                    null,
                                    'g',
                                    null),
                                'u',
                                null),
                            'b',
                            new Tree(
                                new Tree(
                                    new Tree(
                                        new Tree(
                                            null,
                                            'e',
                                            null),
                                        'd',
                                        null),
                                    'o',
                                    null),
                                'c',
                                null)),
                        'e',
                        null),
                    'd',
                    null))
            );
        [Fact]
        public void TrueTest()
        {
            Assert.True(TDictionary.Exist(tree, "a"));
            Assert.True(TDictionary.Exist(tree, "add"));
            Assert.True(TDictionary.Exist(tree, "all"));
            Assert.True(TDictionary.Exist(tree, "ally"));
            Assert.True(TDictionary.Exist(tree, "alt"));
            Assert.True(TDictionary.Exist(tree, "alter"));
            Assert.True(TDictionary.Exist(tree, "code"));
            Assert.True(TDictionary.Exist(tree, "debug"));
            Assert.True(TDictionary.Exist(tree, "decode"));
        }
        [Fact]
        public void FalseTest()
        {
            Assert.False(TDictionary.Exist(tree, "ac"));
            Assert.False(TDictionary.Exist(tree, "dll"));
            Assert.False(TDictionary.Exist(tree, "ly"));
            Assert.False(TDictionary.Exist(tree, "ode"));
            Assert.False(TDictionary.Exist(tree, "bug"));
            Assert.False(TDictionary.Exist(tree, "e"));
        }
    }
}
