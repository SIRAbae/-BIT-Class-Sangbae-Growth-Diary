package example3;

public class Sol extends Person {
	public Sol(String _name) {
		super(_name);
		
	}

	public void training() {
		System.out.println(toString() + ":" + "�� �Ʒ��Ѵ�.");
	}
	
	@Override
	public void Print() {
		System.out.println("���� :"+ toString());
		System.out.println("���� :"+ getNumber());
	}
}