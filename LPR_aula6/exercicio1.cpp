#include <iostream>
using namespace std;

int funcaoinverter (int x )
{
    int reverso = 0;

    while (x != 0)
    {
        int digito = x % 10;
        reverso = reverso * 10 + digito;
        x /= 10;
    }
    return reverso;
}
int main()
{
std::cout << "digite um número inteiro que retornará o reverso dele ";
int x;
std ::cin >> x;

std::cout << "reverso: " << funcaoinverter(x) << endl;

return 0;
}
