namespace PageRankWork;

public class PageRank
{
    private int[,] webGraph;
    private double[] pageRank;
    private double dampingFactor;
    private double tolerance;
    private int maxIterations;

    public PageRank(int[,] webGraph, double dampingFactor, double tolerance, int maxIterations)
    {
        this.webGraph = webGraph;
        this.dampingFactor = dampingFactor;
        this.tolerance = tolerance;
        this.maxIterations = maxIterations;


        pageRank = new double[webGraph.GetLength(0)];
        for (int i = 0; i < webGraph.GetLength(0); i++)
        {
            pageRank[i] = 1.0 / webGraph.GetLength(0);
        }
    }

    public double[] CalculatePageRank()
    {
        bool keepGoing = true;
        int iteration = 0;

        while (keepGoing && iteration < maxIterations)
        {
            // Распределение ранга страниц
            for (int i = 0; i < webGraph.GetLength(0); i++)
            {
                pageRank[i] = (1 - dampingFactor) / webGraph.GetLength(0);
                for (int j = 0; j < webGraph.GetLength(0); j++)
                {
                    if (webGraph[j, i] > 0)
                    {
                        int outLinks = 0;
                        for (int k = 0; k < webGraph.GetLength(0); k++)
                        {
                            outLinks += webGraph[j, k] > 0 ? 1 : 0;
                        }
                        pageRank[i] += dampingFactor * (pageRank[j] / outLinks);
                    }
                }
            }

            // Проверка сходимости
            keepGoing = false;
            for (int i = 0; i < webGraph.GetLength(0); i++)
            {
                if (Math.Abs(pageRank[i] - pageRank[i]) > tolerance)
                {
                    keepGoing = true;
                    break;
                }
            }

            // Обновление рангов страниц
            for (int i = 0; i < webGraph.GetLength(0); i++)
            {
                pageRank[i] = pageRank[i];
            }

            iteration++;
        }

        return pageRank;
    }
}
