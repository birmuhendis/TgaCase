using VaderSharp2;

namespace TgaCase.SharedKernel.Utilities
{
    public static class SentimentAnalysis
    {
        public static SentimentAnalysisResults Analiysis(string comment)
        {
            SentimentIntensityAnalyzer analyzer = new SentimentIntensityAnalyzer();
            //türkçe cümleyi ingilizceye çevirerek analizi ingilizce yapıyor
            var eng = TranslateUtil.TurkishToEnglish(comment);
            var results = analyzer.PolarityScores(eng);

            return results;
        }
    }
}