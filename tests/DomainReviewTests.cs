using Depglass;

public static class DomainReviewTests
{
    public static void Run()
    {
        var item = new DomainReview(58, 44, 11, 61);
        if (DomainReviewLens.Score(item) != 188) throw new Exception("domain score mismatch");
        if (DomainReviewLens.Lane(item) != "ship") throw new Exception("domain lane mismatch");
    }
}
