package example3;

public class Start {
	public static void main(String[] args) {
		Person[] per = new Person[3];
		per [0] = new Stu("학생");
		per [1] = new Sol("군인");
		per [2] = new Emp("회사원");
		
		
		Stu stu = (Stu)per[0];
		stu.setNumber(192513);
		stu.setUni("우송대");
		stu.study();//학생이 공부한다.
		stu.Print(); //학생/192513/우송대
		
		Sol sol = (Sol)per[1];
		sol.setNumber(1676019304);
		sol.training();
		sol.Print();
		
		Emp emp = (Emp)per[2];
		emp.setPart("인사팀");
		emp.study();//회사원이 공부한다.
		emp.work();//회상원이 일한다.
		emp.Print();
	}
}
