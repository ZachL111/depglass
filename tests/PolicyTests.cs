using Depglass;

public static class PolicyTests
{
    public static void Run()
    {
        var signalcase_1 = new Signal(73, 75, 16, 20, 4);
        if (Policy.Score(signalcase_1) != 57) throw new Exception("score mismatch");
        if (Policy.Classify(signalcase_1) != "review") throw new Exception("decision mismatch");
        var signalcase_2 = new Signal(85, 78, 27, 18, 8);
        if (Policy.Score(signalcase_2) != 89) throw new Exception("score mismatch");
        if (Policy.Classify(signalcase_2) != "review") throw new Exception("decision mismatch");
        var signalcase_3 = new Signal(91, 81, 24, 20, 8);
        if (Policy.Score(signalcase_3) != 99) throw new Exception("score mismatch");
        if (Policy.Classify(signalcase_3) != "review") throw new Exception("decision mismatch");
    }
}
