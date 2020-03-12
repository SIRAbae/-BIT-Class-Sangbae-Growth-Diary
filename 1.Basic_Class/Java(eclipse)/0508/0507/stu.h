#pragma once
#include <iostream>
#include <string>
using namespace std;

//������ Ŭ����
class stu
{
	//��������� ����
private:
	const int num;		//��� ���, ����� ������ �ʱ�ȭ�� �̷�������, �ʱ�ȭ�Ǹ� �ٲ��� ����
	string name;
	string phone;

	//������ �Ҹ��� �����
public:
	stu(int _num, string _name, string _phone);
	~stu();

	//get set �޼��� �����
public:
	int getNum() const		{ return num;	}
	string getName() const	{ return name;	}
	string getPhone() const	{ return phone; }
	void setPhone(string value) { phone = value; }

	//�Ϲ����� �޼��� �����
public:
	void print() const
	{
		cout << num << "\t";
		cout << name.c_str() << "\t";
		cout << phone.c_str() << endl;
	}
};

class CompareByNum //page 115
{
	int num;
public:
	CompareByNum(int _num) { num = _num; }
	bool operator()(stu* stu)
	{
		return (stu && stu->getNum() == num);
	}

};

class CompareByName //page 115
{
	string name;
public:
	CompareByName(string _name) {name = _name; }
	bool operator()(stu* stu)
	{
		return (stu && stu->getName() == name);
	}

};
