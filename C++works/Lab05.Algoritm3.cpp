#include <iostream>
#include <string>
using namespace std;

int main(){
  char user1, user2, x;
  string name1, name2;
  cout << "\nНачать игру?\n Y- да N- нет ";
  cin >> x;
  if (x == 'n' ){
    exit(1);
  }
  else {
  cout << "Первый игрок введите своё имя: ";
  cin >> name1;
  cout << "Второй игрок введите своё имя: ";
  cin >> name2;
  while (true) {
  cout << "r-камень" << endl << "p-бумага" << endl << "s-ножницы" << endl << "Первый игрок делает ход: ";
  cin >> user1;
  cout << "Второй игрок делает ход: ";
  cin >> user2;
  switch (user1) {
    case 'r':
    if (user2 == 'r') {
      cout << "Победила дружба!";
    } else if (user2 == 'p') {
      cout << "Выигрывает второй игрок, под именем: " << name2 << endl;
    } else if (user2 ==  's') {
      cout << "Выигрывает первый игрок под именем: " << name1 << endl; }
      cout << "\nНачать игру?\n Y- да N- нет ";
  cin >> x;
  if (x == 'n' ){
    exit(1);
  }
    break;
    case 'p':
    if (user2 == 'p') {
      cout << "Победила дружба!";
    } else if (user2 == 's') {
      cout << "Выигрывает второй игрок, под именем: " << name2 << endl;
    } else if (user2 ==  'r') {
      cout << "Выигрывает первый игрок под именем: "<< name1 << endl; }
      cout << "\nНачать игру?\n Y- да N- нет ";
  cin >> x;
  if (x == 'n' ){
    exit(1);
  }
    break;
    case 's':
    if (user2 == 's') {
      cout << "Победила дружба!";
    } else if (user2 == 'p') {
      cout << "Выигрывает первый игрок под именем: " << name1 << endl ;
    } else if (user2 ==  'r') {
      cout << "Выигрывает второй игрок под именем: " << name2 << endl; }
      cout << "\nНачать игру?\n Y- да N- нет ";
  cin >> x;
  if (x == 'n' ){
    exit(1);
  }
    break;}
} } return 0; }
