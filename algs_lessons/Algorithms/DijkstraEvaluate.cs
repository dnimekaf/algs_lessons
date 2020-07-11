using System;
using System.Collections.Generic;

namespace algs_lessons.Algorithms
{
    public class DijkstraEvaluate
    {
        public double Evaluate(String expression) {
            var ops = new Stack<string>();
            var vals = new Stack<double>();
            string[] parts = expression.Split(" ");
            foreach (var part in parts)
            {
                switch (part)
                {
                    case "(": break;
                    case "+":
                    case "-":
                    case "*":
                    case "/":
                    case "sqrt":
                        ops.Push(part);
                        break;
                    case ")":
                    {
                        String op = ops.Pop();
                        double v = vals.Pop();
                        switch (op)
                        {
                            case "+":
                                v = vals.Pop() + v;
                                break;
                            case "-":
                                v = vals.Pop() - v;
                                break;
                            case "*":
                                v = vals.Pop() * v;
                                break;
                            case "/":
                                v = vals.Pop() / v;
                                break;
                            case "sqrt":
                                v = Math.Sqrt(v);
                                break;
                        }

                        vals.Push(v);
                    }
                        break;
                    default: vals.Push(Double.Parse(part));
                        break;
                }
            }
            return vals.Pop();
        }
    }
}