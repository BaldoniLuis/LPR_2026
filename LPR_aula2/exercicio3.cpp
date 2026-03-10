# include <iostream>
# include <iomanip>

using namespace std;

main ()
{
 cout << "Digite seu número de funcionário: ";
int numeroFuncionario;
cin >> numeroFuncionario;
cout << "Digite seu número de horas trabalhadas: ";
int horasTrabalhadas;
cin >> horasTrabalhadas;
cout << "Digite o valor que recebe por hora: ";
float valorHora;
cin >> valorHora;
float salario = horasTrabalhadas * valorHora;
cout << fixed << setprecision(2);
cout << "Número do funcionário: " << numeroFuncionario << endl;
cout << "Salário: R$ " << salario << endl;
std::cout << std::fixed << std::setprecision(2) << "Salário: R$ " << salario << std::endl;
cout << "Salário: R$ " << salario << endl;

}
