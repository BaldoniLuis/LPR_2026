#include <iostream>
#include <map>
#include <string>

using namespace std;

int main() {
    map<string, int> pessoas;
    int x;

    cout << "Quantas pessoas deseja cadastrar? ";
    cin >> x;

    for (int i = 0; i < x; i++) {
        string nome;
        int idade;

        cout << "\nNome da pessoa " << i + 1 << ": ";
        cin >> nome;

        cout << "Idade: ";
        cin >> idade;

        pessoas[nome] = idade;
    }

    double soma = 0;

    for (auto p : pessoas) {
        soma += p.second;
    }

    double media = soma / pessoas.size();

    cout << "\nMedia das idades: " << media << endl;

    cout << "\nPessoas com idade acima da media:\n";
    for (auto p : pessoas) {
        if (p.second > media) {
            cout << p.first << " (" << p.second << " anos)" << endl;
        }
    }

    string maisVelha, maisNova;
    int idadeMax = -1;
    int idadeMin = 999;

    for (auto p : pessoas) {
        if (p.second > idadeMax) {
            idadeMax = p.second;
            maisVelha = p.first;
        }

        if (p.second < idadeMin) {
            idadeMin = p.second;
            maisNova = p.first;
        }
    }

    cout << "\nPessoa mais velha: " << maisVelha
         << " (" << idadeMax << " anos)" << endl;

    cout << "Pessoa mais nova: " << maisNova
         << " (" << idadeMin << " anos)" << endl;

    int y;
    cout << "\nDigite uma idade para remover: ";
    cin >> y;

    for (auto it = pessoas.begin(); it != pessoas.end(); ) {
        if (it->second == y) {
            it = pessoas.erase(it);
        } else {
            ++it;
        }
    }

    cout << "\nDicionario atualizado:\n";

    for (auto p : pessoas) {
        cout << p.first << " - " << p.second << " anos" << endl;
    }

    return 0;
}