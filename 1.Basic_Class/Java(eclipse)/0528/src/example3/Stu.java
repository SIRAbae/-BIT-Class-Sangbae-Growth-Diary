package example3;

public class Stu extends Person implements Study {

	public Stu(String _name) {
		super(_name);
		
	}

	
	@Override
	public void study() {
		System.out.println(toString() + ":" + "이 공부한다.");
	}

	@Override
	public void Print() {
		System.out.println("직업 :"+ toString());
		System.out.println("학번 :"+ getNumber());
		System.out.println("학교 :"+ getUni());

		
	}

}
  