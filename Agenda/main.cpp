#include <iostream>
#include <string>

using namespace std;

// Registro
struct Contacto {
    string nombre;
    string telefono;
    string email;
};

// Vector
Contacto agenda[50];
int contador = 0;

// Funciones
void agregarContacto() {
    if (contador >= 50) {
        cout << "Agenda llena.\n";
        return;
    }

    Contacto c;
    cout << "Nombre: ";
    getline(cin, c.nombre);
    cout << "Telefono: ";
    getline(cin, c.telefono);
    cout << "Email: ";
    getline(cin, c.email);

    agenda[contador] = c;
    contador++;
    cout << "Contacto agregado correctamente.\n";
}

void listarContactos() {
    cout << "\n--- LISTA DE CONTACTOS ---\n";
    for (int i = 0; i < contador; i++) {
        cout << i + 1 << ". "
             << agenda[i].nombre << " | "
             << agenda[i].telefono << " | "
             << agenda[i].email << endl;
    }
}

void buscarContacto() {
    string buscar;
    cout << "Ingrese nombre a buscar: ";
    getline(cin, buscar);

    for (int i = 0; i < contador; i++) {
        if (agenda[i].nombre == buscar) {
            cout << "Contacto encontrado:\n";
            cout << agenda[i].nombre << " | "
                 << agenda[i].telefono << " | "
                 << agenda[i].email << endl;
            return;
        }
    }
    cout << "Contacto no encontrado.\n";
}

int main() {
    int opcion;

    do {
        cout << "\n--- AGENDA TELEFONICA ---\n";
        cout << "1. Agregar contacto\n";
        cout << "2. Listar contactos\n";
        cout << "3. Buscar contacto\n";
        cout << "4. Salir\n";
        cout << "Opcion: ";
        cin >> opcion;
        cin.ignore();

        switch (opcion) {
            case 1: agregarContacto(); break;
            case 2: listarContactos(); break;
            case 3: buscarContacto(); break;
            case 4: cout << "Saliendo...\n"; break;
            default: cout << "Opcion invalida\n";
        }
    } while (opcion != 4);

    return 0;
}
