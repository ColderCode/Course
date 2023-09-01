namespace CodeRules
{
    // 大驼峰命名
    class Program
    {

    }
    interface IEatFood
    {

    }
    struct Bird
    {
        public string Species;
        public int Age;

        // 大驼峰
        public void Fly()
        {
            Console.WriteLine("flying.");
        }
    }

    // 小驼峰命名
    class Dog
    {
        public int hungary = 0;
        public void EatFood(string foodName)
        {
            hungary += 1;
            Console.WriteLine("eating " + foodName);

        }
    }

    // 常量命名
    class Cat
    {
        const string FUR_COLOR = "black"

        public void Desc()
        {
            const string GENDER = "male"
            Console.WriteLine("i am " + FUR_COLOR)
            Console.WriteLine("i am " + GENDER)
        }
    }

    // 特殊前后缀
    interface ICodeRules
    {

    }

    class ValueException
    {

    }

    class CatTest
    {

    }

    // 变量复数形式
    class Teacher
    {
        List<string> children = new List<string>();
        List<string> studentList = new List<string>();
    }

    // 默认枚举值不加s
    enum Day
    {
        SUN,
        MON,
        SAT,
    }

    // 指定枚举值加s
    enum StatusTypes
    {
        SUCCESS = 200,
        SERVER_ERROR = 500,
        CLIENT_ERROR = 400
    }

    // 变量可读性
    class HumanVar
    {
        // 使用英语拼写
        private int studentCount = 1;

        // 错误示例
        private int studentshuliang = 1;
        private int xueshengshuliang = 1;

        // 错误示例
        private var zeus = 100;
        private int a = 1;

    }


    // lint
    class Mouse
    {

    }

    class MouseRed
    {

    }

    class MouseBlue { }


    // 悬挂缩进
    class NewLine
    {
        public void SomeMethod()
        {
            string message = "This is a long message that exceeds "
                             + "the maximum character limit.";

            if (result > 0
                && message.Length > 100)
            {
                Console.WriteLine("Both conditions are met.");
            }

            SomeObject obj = new SomeObject();
            obj.Method1()
               .Method2()
               .Method3();

            AnotherMethod(
                "parameter1",
                "parameter2",
                "parameter3"
            );
        }
    }

    class LintRule
    {
        public void SomeMethod()
        {
            // 其他lint规范
            if (true)
            {

            }

            for (int i = 0; i < length; i++)
            {

            }

            // 做第一个步骤
            int a = 1;
            int b = 2;

            // 做第二个步骤，步骤之间空一行

            // 错误示例
            int studentCount = 3;
            int catCount = 4;
        }
    }


    class ProgramRule
    {
        public static void Main()
        {
            // 显性说明return、break、continue逻辑
            if (value == 1)
            {
                return
            }
            else
            {
                return
            }

            for (int i = 0; i < 10; i++)
            {
                if (i == 1)
                {
                    continue
                }
                if (i + 4 == 13)
                {
                    break
                }
            }


            // 错误示例
            int result = 0;
            if (result == 0)
            {
                result += 1;
            }
            else
            {
                return result
            }
            return result

            if (true) result += 1;

            // 条件判断异常分支拆分
            int count = 10;
            if (count == 10)
            {
                count += 1;
            }
            // if 的内容和其他逻辑不会重叠，后面不用else
            count += 1;


            // 使用高可读性的变量代替复杂判断逻辑
            int catCount = 1;
            int dogCount = 2;
            int birdCount = 3;

            bool foodExpensive = (catCount + dogCount + birdCount) > 3;

            if (foodExpensive)
            {

            }

            // 错误示例
            if ((catCount + dogCount + birdCount) > 3)
            {

            }

            // 错误处理
            try
            {

            }
            catch (System.Exception)
            {

                throw;
            }

        }
    }

    /// <summary>
    /// 这是一个示例类，用于演示注释格式。
    /// </summary>
    class Comment
    {

        // 常量，当前国家
        const string LOCAL = "China"

        /// <summary>
        /// 这是一个示例方法，用于演示注释格式。
        /// </summary>
        /// <param name="param1">第一个参数的说明。</param>
        /// <param name="param2">第二个参数的说明。</param>
        /// <returns>返回值的说明。</returns>
        public void ExampleMethod(int param1, string param2)
        {
            // 方法的实现
            CommentDay.SUN
        }

        public void Method()
        {
            ExampleMethod(1,2)
        }


        // 字段的注释
        private int exampleField;

        /// <summary>
        /// 这是一个示例属性，用于演示注释格式。
        /// </summary>
        public int ExampleProperty { get; set; }
    }


    
    enum CommentDay
    {
        // 周日
        SUN,
        // 周一
        MON,
        // 周二
        SAT,
    }


}