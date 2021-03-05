Lista zadań ( To-Do list )

  	Projekt powstał by pomóc użytkownikom w organizacji czasu, będzie przedstawiał listę zadań do zrobienia napisanych przez użytkownika.
Użytkownik może w każdej chwili dodać, usunąć lub edytować wpis do listy zadań. Dostępna będzie również dodatkowa funkcja „wykonane” aby zadania, 
które zostały wykonane zostały przekreślone na liście. Do sprawdzenia listy zadań należy poprawnie przejść proces logowania się (w przypadku pierwszej 
wizyty – rejestracji). Po wylogowaniu się nie ma możliwości przejrzenia listy zadań. 

	  Projekt jest zabezpieczony przed Broken Authentication. W głównym kontrolerze TodoesController filtr autoryzacji jest uruchamiany 
na starcie [Authorize], przed jakąkolwiek akcją kontrolera. Filtr ten sprawdza, czy użytkownik jest uwierzytelniony. Jeśli nie, 
zwraca kod stanu HTTP 401 (nieautoryzowany) bez wywoływania akcji. Dzięki czemu nie ma możliwości podejrzenia

Funkcje:
-dodaj 
-usuń
-edytuj
-wykonane (przekreśla rzecz do zrobienia
