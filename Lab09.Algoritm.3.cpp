#include <iostream>
#include <set>
 
using namespace std;
 
int main()
{
	set <int> s1, s2;
	int n, m;
	cin >> n;
	for(int i = 0; i < n; i++)
	{
		int a;
		cin >> a;
		s1.insert(a);
	}
	cin >> m;
	int k = 0;
	for(int i = 0; i < m; i++)
	{
		int a;
		cin >> a;
		s2.insert(a);
		if(s1.find(a) != s1.end())
			k++;
	}
	cout << k;
	return 0;
}