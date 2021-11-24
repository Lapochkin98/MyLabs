#include <iostream>
using namespace std;
//LU разложение матриц

const int n = 4;
const int m = 5;
void LU(double arr[][m], double U[][n], double L[][n], const int n, double* X, double* Y) {

    for (int k = 0; k < n; k++) {
        for (int i = 0; i < n; i++) {
            if (k <= i) {
                L[i][k] = arr[i][k];
                for (int j = 0; j < k; j++) {
                    L[i][k] -= L[i][j] * U[j][k];
                }
            }
            else {
                U[i][k] = arr[i][k];
                for (int j = 0; j < i; j++) {
                    U[i][k] -= L[i][j] * U[j][k];
                }
                U[i][k] = U[i][k] / L[i][i];
            }
        }
    }
    cout << "Матрица L:" << endl;
    for (int i = 0; i < n; i++) {
        for (int j = 0; j < n; j++) {
            cout << "| " << L[i][j] << " ";
        }
        cout << endl;
    }
    cout << "Матрица U:" << endl;
    for (int i = 0; i < n; i++) {
        for (int j = 0; j < n; j++) {
            cout << "| " << U[i][j] << " ";
        }
        cout << endl;
    }
    for (int i = 0; i < n; i++) {
        Y[i] = arr[i][n];

        for (int j = 0; j < i; j++) {
            Y[i] -= L[i][j] * Y[j];
        }
        Y[i] = Y[i] / L[i][i];
    }
    cout << "Y:" << endl;
    for (int i = 0; i < n; i++) {
        cout << "| " << Y[i] << " ";
    }
    cout << endl;
    for (int i = n - 1; i >= 0; i--) {
        X[i] = Y[i];
        for (int j = i + 1; j < n; j++) {
            X[i] -= U[i][j] * X[j];
        }
        X[i] = X[i] / U[i][i];
    }
    cout << "X:" << endl;
    for (int i = 0; i < n; i++) {
        cout << "| " << X[i] << " ";
    }
    cout << endl;


}

int main() {
    setlocale(LC_ALL, "rus");

    double d[4][5] = {
    {6.1, 1.7, -2.1, -7.7, 3.1},
    {-10, 1.3, -20, -1.4, 4.5},
    {1.8, 1.7, 4.9, 4.8, 1.2},
    {8, 32.4, -2.1, -10, -1.1},
    };


    double L[n][n];
    double U[n][n];

    cout << "Матрица под именем L:\n";
    for (int i = 0; i < n; i++) {
        for (int j = 0; j < n; j++) {
            L[i][j] = 0;
            cout << "| " << L[i][j] << " ";

        }
        cout << endl;
    }

    cout << "Матрица под именем U:\n";
    for (int i = 0; i < n; i++) {
        for (int j = 0; j < n; j++) {
            U[i][j] = 0;

            if (i == j)
            {
                U[i][j] = 1;
            }



            cout << "| " << U[i][j] << " ";
        }
        cout << endl;

    }

    double X[n];
    double Y[n];


    LU(d, U, L, n, X, Y);
    return 0;
}
