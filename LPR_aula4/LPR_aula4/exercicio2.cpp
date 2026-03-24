#include <iostream>
using namespace std;
 
int main()
{
int x,y;
cout << "Digite dois números e veremos se eles são múltiplos ";
cin >> x >> y;

if (x!=0 && x % y == 0 || y!=0 && y % x == 0)
{
    cout << "Os números digitados são multiplos !";
}
else
{
   cout << "Os números digitados não são multiplos !";
}

}
