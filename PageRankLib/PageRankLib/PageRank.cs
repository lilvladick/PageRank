using System;

namespace PageRankWork
{
    public class PageRank
    {
        private int[,] _webGraph;
        private double[] _pageRank;
        private double _dampingFactor;
        private double _tolerance;
        private int _maxIterations;

        public PageRank(int[,] webGraph, double dampingFactor, double tolerance, int maxIterations)
        {
            this._webGraph = webGraph;
            this._dampingFactor = dampingFactor;
            this._tolerance = tolerance;
            this._maxIterations = maxIterations;

            _pageRank = new double[webGraph.GetLength(0)];
            for (int i = 0; i < webGraph.GetLength(0); i++)
            {
                _pageRank[i] = 1.0 / webGraph.GetLength(0);
            }
        }

        public double[] CalculatePageRank()
        {
            bool keepGoing = true;
            int iteration = 0;

            while (keepGoing && iteration < _maxIterations)
            {
                double[] newPageRank = new double[_webGraph.GetLength(0)];

                for (int i = 0; i < _webGraph.GetLength(0); i++)
                {
                    double newRank = (1 - _dampingFactor) / _webGraph.GetLength(0);

                    for (int j = 0; j < _webGraph.GetLength(0); j++)
                    {
                        if (_webGraph[j, i] > 0)
                        {
                            int outLinks = 0;
                            for (int k = 0; k < _webGraph.GetLength(0); k++)
                            {
                                outLinks += _webGraph[j, k] > 0 ? 1 : 0;
                            }
                            newRank += _dampingFactor * (_pageRank[j] / outLinks);
                        }
                    }
                    newPageRank[i] = newRank;
                }

                keepGoing = false;
                for (int i = 0; i < _webGraph.GetLength(0); i++)
                {
                    if (Math.Abs(newPageRank[i] - _pageRank[i]) > _tolerance)
                    {
                        keepGoing = true;
                        break;
                    }
                }

                _pageRank = newPageRank;
                iteration++;
            }

            return _pageRank;
        }
    }
}
