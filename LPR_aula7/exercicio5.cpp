int matriz [3][3];
int soma = 0;

cout << "Digite os numeros inteiros";

for (int i = 0; i < 3; i++) {
    for (int j = 0; j < 3; j++) {
        cin >> matriz[i][j];
        soma += matriz[i][j];
    }
}

for (int i = 0; i < 3; i++) {
    for (int j = 0; j < 3; j++) {
        cout << matriz[i][j] << "\t";
    }
    cout << endl;
}
cout << "\nSoma =  " << soma << endl;
