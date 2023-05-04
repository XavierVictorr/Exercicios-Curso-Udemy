using system;

namespace DiagonalNegativa {

    class Program {

        static void Main(string[] args) {

            int n, cont;

            console.Write("Qual a ordem da matriz? ");
            n = int.Parse(console.readline());

            int[,] mat = new int[n, n];

            for (int i = 0; i < n; i++) {
                for (int j = 0; j < n; j++) {
                    console.write("elemento [" + i + "," + j + "]: ");
                    mat[i, j] = int.parse(console.readline());
                }
            }
            console.WriteLine("diagonal principal: ");
            for (int i = 0;i < n; i++) {
                console.write(mat[i, i] + " ");            
            }
            console.writeline();

            cont = 0;
            for (int i = 0; i < n: i++) {
                for (int j = 0;j < n; j++) {
                    if (mat[i, j] < 0) {
                        cont = cont + 1;

                    }
                }
            }
            console.writeline("quantidade de negativos = " + cont);
        }
    }
}