# на Отлично в одного человека надо сделать консольное приложение Телефонный справочник 
# с внешним хранилищем информации, и чтоб был реализован основной функционал - просмотр, сохранение, импорт, поиск, удаление.
# Задача 38: Дополнить телефонный справочник возможностью изменения и удаления данных. 
# Пользователь также может ввести имя или фамилию, и Вы должны реализовать функционал для изменения и удаления данных
# для отлично в группах надо выполнить или ТГ бот или ГУИ (это когда кнопочки и поля ввода как в Виндовс приложениях) 
# или БД ГУИ можно сделать просто на EasyGUI или Tkinter
from random import *
import json

phone_book = {}

def save():
    with open("phonebook.json", "w", encoding="utf-8") as fh:
        fh.write(json.dumps(phone_book, ensure_ascii=False))
    print("Телефонная книга сохранена в файле phonebook.json")
def load():
    # global phone_book
    with open("phonebook.json", "r", encoding="utf-8") as fh:
        phone_book = json.load(fh)
    print("Загрузка контактов выполнена успешно")
    return phone_book
# --------------------------------------------------------------

def add_contact():
    name = input("Введите имя контакта: ")
    number = input("Введите номер телефона контакта: ")
    phone_book[name] = number
    print("Контакт добавлен")

def search_contact():
    name = input("Введите имя контакта для поиска: ")
    if name in phone_book:
        print(f"Номер телефона контакта {name}: {phone_book[name]}")
    else:
        print("Контакт не найден в телефонной книге.")

def show_all_contacts():
    if phone_book:
        print("Список контактов:")
        for name, number in phone_book.items():
            print(f"{name}: {number}")
    else:
        print("Телефонная книга пуста.")                                           

def delete_contact():
    name = input("Введите имя контакта для удаления: ")
    if name in phone_book:
        del phone_book[name]
        print("Контакт удален!")
    else:
        print("Контакт не найден в телефонной книге.")

def main():
    while True:
        print("Телефонная книга")
        print("1. Добавить контакт")
        print("2. Поиск контакта")
        print("3. Показать все контакты")
        print("4. Удалить контакт")
        print("5. Сохранить телефонную книгу")
        print("6. Загрузитьить телефонную книгу")
        print("7. Выйти")
        global phone_book
        choice = input("Выберите действие (1-5): ")
        
        if choice == "1":
            add_contact()
        elif choice == "2":
            search_contact()
        elif choice == "3":
            show_all_contacts()
        elif choice == "4":
            delete_contact()
        elif choice == "5":
            save()
        elif choice == "6":
            phone_book = load()
        elif choice == "7":
            print("До свидания!")
            break
        else:
            print("Неверный выбор. Попробуйте снова.")
        print()

if __name__ == "__main__":
    main()