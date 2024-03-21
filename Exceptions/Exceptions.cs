namespace cw3.Exceptions;

public class OverfillException : Exception {
    public OverfillException() {}
    public OverfillException(string message) : base(message) {}
}

public class TooColdException : Exception {
    public TooColdException() {}
}
