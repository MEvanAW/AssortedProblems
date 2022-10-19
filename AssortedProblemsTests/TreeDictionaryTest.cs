using TreeDictionary;

namespace AssortedProblemsTests
{
    public class TreeDictionaryTest
    {
        private readonly Tree tree1 = new(
            new Tree(
                new Tree(
                    null,
                    'd',
                    null),
                'd',
                new Tree(
                    new Tree(
                        null,
                        'l',
                        null),
                    'l',
                    new Tree(
                        new Tree(
                            new Tree(
                                new Tree(
                                    null,
                                    'c',
                                    null),
                                'e',
                                null),
                            't',
                            null),
                        'z',
                        null))),
            'a',
            null);
        private readonly Tree tree2 = new(
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
        public void TrueTest1()
        {
            Assert.True(TDictionary.Exist(tree1, "a"));
            Assert.True(TDictionary.Exist(tree1, "add"));
            Assert.True(TDictionary.Exist(tree1, "all"));
            Assert.True(TDictionary.Exist(tree1, "az"));
            Assert.True(TDictionary.Exist(tree1, "aztec"));
        }
        [Fact]
        public void FalseTest1()
        {
            Assert.False(TDictionary.Exist(tree1, "adl"));
            Assert.False(TDictionary.Exist(tree1, "ally"));
            Assert.False(TDictionary.Exist(tree1, "dlz"));
            Assert.False(TDictionary.Exist(tree1, "dll"));
            Assert.False(TDictionary.Exist(tree1, "ec"));
        }
        [Fact]
        public void TrueTest2()
        {
            Assert.True(TDictionary.Exist(tree2, "a"));
            Assert.True(TDictionary.Exist(tree2, "add"));
            Assert.True(TDictionary.Exist(tree2, "all"));
            Assert.True(TDictionary.Exist(tree2, "ally"));
            Assert.True(TDictionary.Exist(tree2, "alt"));
            Assert.True(TDictionary.Exist(tree2, "alter"));
            Assert.True(TDictionary.Exist(tree2, "code"));
            Assert.True(TDictionary.Exist(tree2, "debug"));
            Assert.True(TDictionary.Exist(tree2, "decode"));
        }
        [Fact]
        public void FalseTest2()
        {
            Assert.False(TDictionary.Exist(tree2, "ac"));
            Assert.False(TDictionary.Exist(tree2, "dll"));
            Assert.False(TDictionary.Exist(tree2, "ly"));
            Assert.False(TDictionary.Exist(tree2, "ode"));
            Assert.False(TDictionary.Exist(tree2, "bug"));
            Assert.False(TDictionary.Exist(tree2, "e"));
        }
    }
}
