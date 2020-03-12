package example3;

public abstract class Person {
	private String name;
	private int number;
	private String part;
	private String uni;
	
	public Person(String _name) {
		name = _name;
	}
	@Override
	public String toString() {
		return name;
	
	}
	public int getNumber() {
		return number;
	}
	public void setNumber(int number) {
		this.number = number;
	}
	public String getPart() {
		return part;
	}
	public void setPart(String part) {
		this.part = part;
	}
	public String getUni() {
		return uni;
	}
	public void setUni(String uni) {
		this.uni = uni;
	}

	public abstract void Print();
	
	
}