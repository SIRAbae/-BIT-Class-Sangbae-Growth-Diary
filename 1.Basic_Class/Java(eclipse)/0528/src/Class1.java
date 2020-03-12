
/*
 * 추상메서드 : 몸체가 없는 메서드
 * 추상클라스 : abstract 키워드를 상요하여 클래스를 정의
 * 만약 모든 메서드가 일반 메서드람녀 -> 추상 or 일 클래스 선택 가능
 * 만약 하나라도 추상 메서드가 존재한다면 -> 무조건 추상 클래스로 정의해야 함
 * 
 * 추상클래스의 성질
 * -> 절대 객체 생성이 불가능하다.
 * -> 부모의 역할로만 사용가능하다.
 * 	자식에 의해서 추상 메서드를 재정의하여 완벽한 형태로 구현.
 */

public abstract class Class1 {
	
	//메서드.
	public void fun1() {
		System.out.println("fun1(");
	}
	
	//추상메서드
	public abstract void fun2();
}
