using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ImitationLab2
{
    public class HeatEquationModel
    {
        public double[] Solve(double length, double tLeft, double tRight, double tInitial,
                             double totalTime, double tau, double h,
                             double rho, double c, double lambda)
        {
            int N = (int)(length / h) + 1;
            int timeSteps = (int)(totalTime / tau);

            if (N < 3)
                throw new Exception("Слишком большой шаг h.");

            double[] T = new double[N];

            // Начальное условие
            for (int i = 0; i < N; i++)
                T[i] = tInitial;

            // Граничные условия
            T[0] = tLeft;
            T[N - 1] = tRight;

            // Коэффициенты
            double A = lambda / (h * h);
            double B = 2 * lambda / (h * h) + rho * c / tau;
            double C = lambda / (h * h);
            double rhs_coef = rho * c / tau;  // Коэффициент для правой части

            // Временные шаги
            for (int step = 0; step < timeSteps; step++)
            {
                // Сохраняем старое распределение для правой части
                double[] T_old = (double[])T.Clone();

                T = SolveTridiagonal(T_old, A, B, C, rhs_coef, tLeft, tRight, N);
            }

            return T;
        }

        private double[] SolveTridiagonal(double[] T_old, double A, double B, double C,
                                          double rhs_coef, double tLeft, double tRight, int N)
        {
            double[] alpha = new double[N];
            double[] beta = new double[N];
            double[] TNew = new double[N];

            // === ПРЯМАЯ ПРОГОНКА ===

            // i = 1
            alpha[1] = A / B;
            beta[1] = (C * tLeft + rhs_coef * T_old[1]) / B;

            // i = 2, 3, ..., N-2
            for (int i = 2; i < N - 1; i++)
            {
                double denom = B - C * alpha[i - 1];
                alpha[i] = A / denom;
                beta[i] = (C * beta[i - 1] + rhs_coef * T_old[i]) / denom;
            }

            // === ОБРАТНАЯ ПРОГОНКА ===

            TNew[N - 1] = tRight;

            for (int i = N - 2; i >= 1; i--)
            {
                TNew[i] = alpha[i] * TNew[i + 1] + beta[i];
            }

            TNew[0] = tLeft;

            return TNew;
        }
    }
}
