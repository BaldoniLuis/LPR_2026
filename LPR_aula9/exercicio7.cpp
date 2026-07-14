#include <iostream>
#include <map>
#include <string>

using namespace std;

int main() {
    map<string, int> cidades;
    int x;

    cout << "Quantas cidades deseja cadastrar? ";
    cin >> x;

    for (int i = 0; i < x; i++) {
        string cidade;
        int populacao;

        cout << "\nNome da cidade " << i + 1 << ": ";
        cin >> cidade;

        cout << "Populacao: ";
        cin >> populacao;

        cidades[cidade] = populacao;
    }

    double soma = 0;

    for (auto c : cidades) {
        soma += c.second;
    }

    double media = soma / cidades.size();

    cout << "\nMedia das populacoes: " << media << endl;

    cout << "\nCidades com populacao acima da media:\n";
    for (auto c : cidades) {
        if (c.second > media) {
            cout << c.first << " (" << c.second << " habitantes)" << endl;
        }
    }

    string maisPopulosa, menosPopulosa;
    int maiorPop = -1;
    int menorPop = 2147483647;

    for (auto c : cidades) {
        if (c.second > maiorPop) {
            maiorPop = c.second;
            maisPopulosa = c.first;
        }

        if (c.second < menorPop) {
            menorPop = c.second;
            menosPopulosa = c.first;
        }
    }

    cout << "\nCidade mais populosa: " << maisPopulosa
         << " (" << maiorPop << " habitantes)" << endl;

    cout << "Cidade menos populosa: " << menosPopulosa
         << " (" << menorPop << " habitantes)" << endl;

    int y;
    cout << "\nDigite uma populacao para remover: ";
    cin >> y;

    for (auto it = cidades.begin(); it != cidades.end(); ) {
        if (it->second == y) {
            it = cidades.erase(it);
        } else {
            ++it;
        }
    }

    cout << "\nDicionario atualizado:\n";
    for (auto c : cidades) {
        cout << c.first << " - " << c.second << " habitantes" << endl;
    }

    return 0;
}