package example3;

public class Stu extends Person implements Study {

	public Stu(String _name) {
		super(_name);
		
	}

	
	@Override
	public void study() {
		System.out.println(toString() + ":" + "�� �����Ѵ�.");
	}

	@Override
	public void Print() {
		System.out.println("���� :"+ toString());
		System.out.println("�й� :"+ getNumber());
		System.out.println("�б� :"+ getUni());

		
	}

}
  