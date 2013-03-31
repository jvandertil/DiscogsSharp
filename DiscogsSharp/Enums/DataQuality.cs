namespace DiscogsSharp.Enums
{
    public enum DataQuality
    {
        Incorrect = int.MinValue,
        NeedsVote = 0,
        NeedsMajorChanges = 1,
        NeedsMinorChanges = 10,
        Correct = 100,
        CompleteAndCorrect = int.MaxValue,
    }
}