package example3;

public class Sol extends Person {
	public Sol(String _name) {
		super(_name);
		
	}

	public void training() {
		System.out.println(toString() + ":" + "이 훈련한다.");
	}
	
	@Override
	public void Print() {
		System.out.println("직업 :"+ toString());
		System.out.println("군번 :"+ getNumber());
	}
}
