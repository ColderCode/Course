---
layout: center
---

# 第五章 Debug的常见姿势

### 保护老腰，多做伸展运动

- 常用窗口
- 常用按钮
- 断点和日志
- 如何调试外部代码

---

## 错误列表

![](https://doc-1314952491.cos.ap-shanghai.myqcloud.com/obsidian/Pasted%20image%2020230915132223.png)



---

## 常用按钮

![](https://doc-1314952491.cos.ap-shanghai.myqcloud.com/obsidian/Pasted%2520image%252020230915110805.png)

![](https://doc-1314952491.cos.ap-shanghai.myqcloud.com/obsidian/Pasted%2520image%252020230915110847.png)

---
layout: image-right
image: https://doc-1314952491.cos.ap-shanghai.myqcloud.com/obsidian/Pasted%20image%2020230915104618.png

---

## 和调试相关的窗口

菜单栏 - 调试 - 窗口
- 自动窗口
- 局部变量
- 监视
- 模块



---

## 自动窗口、局部变量、监视

![](https://doc-1314952491.cos.ap-shanghai.myqcloud.com/obsidian/Pasted%2520image%252020230915104943.png)

命中断点暂停以后，通过这几个窗口可以查看断点上下文中的变量。

---

## 如何调试外部代码

一个常见的场景是，我引用了别人的包、dll，或者一些官方dll，代码运行进去以后报了一个意义不明的错误。

此时可以通过调试外部代码来进入别人的代码进行调试。

要允许调试外部代码，需要做这几个操作：

- 工具 - 选项
	- 调试：取消勾选【启用“仅我的代码”】
		- 符号
			- （可选）勾选【Microsoft 符号服务器】和【NuGet.org 符号服务器】
			- （可选）勾选【仅加载指定的模块】
	- Environment：勾选【在解决方案资源管理器中显示杂项文件】

---
layout: image-right
image: https://doc-1314952491.cos.ap-shanghai.myqcloud.com/obsidian/Pasted%20image%2020230915110618.png

---

然后打开模块窗口（调试 - 窗口 - 模块）

在其中找到想要调试的，引用的目标dll
- 如果它是微软官方的某些包和依赖，那么可能可以从符号服务器中加载符号
- 否则，右键选择【将源反编译为符号文件】，反编译的文件将会出现在解决方案的杂项文件中，此时可以在反编译的文件中打断点。

---

## 断点的局限性

断点处理的是一个非常局部的问题，但有时候bug并不出现在局部，或者这个局部并不容易定位。

例如，
- 遍历一千个数据的过程中，有一个数据有问题
- 程序最终运行结果不对，但是并不知道错误发生在哪里，而每次运行都要做很多动作，花很多时间，很麻烦
- 程序结构比较复杂，设置了多级的异常捕获逻辑，出现问题的第一时间并不能定位到错误发生在哪一级。

当程序规模变大时，需要使用日志来处理。日志也常常配合异常捕获使用。

---

logger的包有很多，这是其中一种：[Serilog官方文档](https://github.com/serilog/serilog/wiki/Getting-Started)

```csharp
Log.Debug("debug");
Log.Information("info");
Log.Warning("warning");
Log.Error("err");
Log.Fatal("fatal");
```

一个Log文件内容示例：

```log
2023-09-13 10:55:14.161 +08:00 [INF] 文档切换 ->D:\桌面\示例文件无门窗.rvt
2023-09-13 10:57:42.250 +08:00 [INF] 开始提交文件
2023-09-13 10:57:45.056 +08:00 [INF] 未读取到LocalDb文件，直接提交
2023-09-13 10:57:45.088 +08:00 [INF] 模型数据读取完成，准备提交
2023-09-13 10:58:31.328 +08:00 [INF] 提交成功
```

logger简单易用，而且可以分类输出到不同的位置，也可以设置调试时输出debug信息，而发布时不输出。

logger一般附带时间输出，可以用于观察代码运行时间，当然也可以
- 使用`StopWatch`类
- 使用VS的调试 - 性能探查器


---
layout: image-right
image: https://doc-1314952491.cos.ap-shanghai.myqcloud.com/obsidian/Pasted%20image%2020230915115410.png
---
## 附加到进程和重新附加

当我的代码被别的第三方程序调用和运行，我想要调试这部分代码，需要附加到目标程序进行调试。

`Ctrl` + `Alt` + `P`

`Shift` + `Alt` + `P`


当然，更建议的做法是配置好生成事件和启动程序，把这个动作也优化掉


---

## 遇到VS错误
- 重开软件解决30%问题
- 重启解决50%问题
- 重装解决90%问题
- 重买解决100%问题





