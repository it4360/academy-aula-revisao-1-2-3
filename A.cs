class Usuario {
    string name;
    B b;
    Endereco[] Cs;

    public void SSS(){
        Usuario a = new Usuario();
        a.b = new B();
        a.b.idade = 10;
        a.Cs = new Endereco[10];
        Endereco cu = new Endereco();
        a.Cs[0] = cu;
    }
}

class B {
    public int idade;
}

class Endereco {
    string fodase;
}