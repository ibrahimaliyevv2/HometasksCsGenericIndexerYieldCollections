# HometasksCsGenericIndexerYieldCollections

Aşağıdakı custom exception-ı yaradın:
- NotAvailableException

Room class
- Id - qıraqdan set etmək olmayacaq yalnız get etmək olacaq və hər dəfə yeni bir Room obyekt yaradıldıqda avtomatik bir vahid artacaq.
- Name
- Price
- PersonCapacity - otağın neçə nəfərlik olduğunu bildirir.
- IsAvailable - otağın rezervasiya olunub olunmadığını göstərir, default olaraq true olmalıdır.
- ShowInfo() - Otağın bütün məlumatlarını göstərir

ToString methodunu override edirsiz və geriyə ShowInfo methodunu qaytarırsız.

ps: Name, Price, PersonCapacity olmadan Room obyekti yaratmaq olmaz

Hotel class
- Name
- Rooms array - içində Room obyektləri saxlayır və private-dır.
- AddRoom() - Parametr olaraq Room obyekti qəbul edib rooms arrayinə əlavə edir.
- MakeReservation() - Parametr olaraq nullable int tipindən bir roomId qəbul edir əgər roomId null olaraq geriyə NullReferanceException qaytarır əks halda göndərilən roomId-li otaq tapılır və IsAvailable dəyəri yoxlanılır əgər IsAvailable dəyəri  false-dusa geriyə yuxarıda yaratdığınız NotAvailableException qaytarılır əgər true-dursa həmin room-un IsAvailable dəyəri true olur.

 İki ədəd room obyekti yaradırsız daha sonra bir hotel obyekti yaradırsız hotel obyektinin içindəki AddRoom methodu vasitəsilə yaratdığınız iki room obyektini hoteldəki rooms arrayinə əlavə edirsiz.
Yarana bilecey  NotAvailableException exceptionunu yoxlayirsiz.
