package example3;

public class Start {
	public static void main(String[] args) {
		Person[] per = new Person[3];
		per [0] = new Stu("�л�");
		per [1] = new Sol("����");
		per [2] = new Emp("ȸ���");
		
		
		Stu stu = (Stu)per[0];
		stu.setNumber(192513);
		stu.setUni("��۴�");
		stu.study();//�л��� �����Ѵ�.
		stu.Print(); //�л�/192513/��۴�
		
		Sol sol = (Sol)per[1];
		sol.setNumber(1676019304);
		sol.training();
		sol.Print();
		
		Emp emp = (Emp)per[2];
		emp.setPart("�λ���");
		emp.study();//ȸ����� �����Ѵ�.
		emp.work();//ȸ����� ���Ѵ�.
		emp.Print();
	}
}