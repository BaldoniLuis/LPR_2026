#include <iostream>
#include <string>
using namespace std;

struct Livro {
    string Titulo;
    string Autor;
    int AnoPublicacao;
    int NumeroPaginas;
    double Preco;
};

int main() {
    const int QTD = 3;
    Livro livros[QTD];

    for (int i = 0; i < QTD; i++) {
        cout << "\n--- Livro " << i + 1 << " ---\n";

        cout << "Titulo: ";
        getline(cin, livros[i].Titulo);

        cout << "Autor: ";
        getline(cin, livros[i].Autor);

        cout << "Ano de Publicacao: ";
        cin >> livros[i].AnoPublicacao;
        cin.ignore();

        cout << "Numero de Paginas: ";
        cin >> livros[i].NumeroPaginas;
        cin.ignore();

        cout << "Preco: R$ ";
        cin >> livros[i].Preco;
        cin.ignore();
    }

    double precoTotal = 0;
    int totalPaginas = 0;

    for (int i = 0; i < QTD; i++) {
        precoTotal += livros[i].Preco;
        totalPaginas += livros[i].NumeroPaginas;
    }

    double mediaPaginas = (double)totalPaginas / QTD;

    cout << "\n========== Resultados ==========\n";
    cout << "Preco total dos livros: R$ " << precoTotal << "\n";
    cout << "Media de paginas:       " << mediaPaginas << " paginas\n";

    return 0;
}