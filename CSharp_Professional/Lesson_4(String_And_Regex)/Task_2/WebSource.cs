using System;
using System.Collections.Generic;
using System.Text;

namespace Task_2
{
    public class WebSource
    {
        public string GetSource(string url)
        {
            return @"
                        <footer class=""site-footer"">
                        <div class=""container"">
                            <div class=""contact-info"">
                                <h3>Зв'яжіться з нами</h3>
                                <p>Наш офіційний email для загальних питань: support@webcatalog.com.ua</p>
                                <p>Для партнерів та преси: media_relations.2026@sub.domain-store.com</p>
            
                                <p>Телефон гарячої лінії (безкоштовно): +380 (44) 123-45-67</p>
                                <p>Мобільний для довідок: 0671234567, або пишіть у месенджери на номер +38093-987-65-43</p>
                                <p>Стаціонарний номер у місті: (044) 444 55 66 (внутр. 102)</p>
                            </div>

                            <div class=""footer-links"">
                                <h3>Навігація</h3>
                                <ul>
                                    <li><a href=""https://main-site.com/about-us"">Про компанію</a></li>
                                    <li><a href=""/privacy-policy"">Політика конфіденційності (відносне посилання)</a></li>
                                    <li><a href=""http://blog.old-archive.org/posts?id=45&category=tech"">Наш старий блог</a></li>
                                    <li><a href=""mailto:hr@webcatalog.com.ua"">Надіслати резюме (посилання mailto)</a></li>
                                    <li><a href=""tel:+380441234567"">Зателефонувати в один клік</a></li>
                                </ul>
                            </div>

                            <div class=""bad-matches"">
                                <p>Цей текст містить просто цифри: 123456789 або код товару № 987-654-321, які не є телефонами.</p>
                                <p>А тут просто вираз без домену: user@host або пошта з помилкою: test@com.</p>
                            </div>
                        </div>
                    </footer>
                    ";
        }
    }
}
