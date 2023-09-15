---
layout: center
---

# 第二章 Visual Studio 安装和简介

### 我不装了，摊牌了，我是亿万富翁

- 关于Visual Studio的三个版本
- 更新Visual Studio
- 获取插件
- 自定义字体和主题

---


## 版本
Visual Studio 分为三个版本：
- 社区版 Community
- 专业版 Professional $45 人/月
- 企业版 Enterprise $250 人/月

---

[Visual Studio Community 2022 许可](https://visualstudio.microsoft.com/zh-hans/license-terms/vs2022-ga-community/)

总结：
个人可以随便用
组织小于5人可以随便用
组织大于5人只能用于
- 开源程序
- VS扩展
- 部分 SQL Server相关开发
- 教育用途

企业（超过250人或者年收入超过100万美元）只能用于：
- 开源代码
- VS扩展
- Windows上的设备驱动程序
- SQL Server
- 教育用途

---
layout: two-cols
---

## 获取功能
工具 - 获取工具和功能

此处可以更新Visual Studio，也可以安装一些组件

注意，Visual Studio相当大，所以最好不要安装在C盘

::right::

<img src="https://doc-1314952491.cos.ap-shanghai.myqcloud.com/obsidian/Pasted%20image%2020230914161018.png" class="m-auto" />

---

## 知识点：运行时、SDK、目标包
[参考资料：官方文档](https://learn.microsoft.com/zh-cn/dotnet/framework/install/guide-for-developers#to-install-the-net-framework-developer-pack-or-targeting-pack)
- 运行时（runtime）：让程序能在windows电脑上运行
- 开发人员工具（SDK - Software Development Kit）：可以开发程序
- 目标包：允许使用高版本开发工具低版本的编译目标。

举例：
我安装了 .Net Framework 4.8 的SDK，此时会自动安装 4.8 版本的目标包
此时我可以开发和编译出4.8版本的程序。

之后我只需要再安装 4.6版本的目标包，就可以开发和编译出4.6版本的程序，不需要安装4.6版本的SDK

---

## 安装插件

扩展 - 管理扩展

![](https://doc-1314952491.cos.ap-shanghai.myqcloud.com/obsidian/Pasted%20image%2020230914163253.png)

---

## 设置字体和主题

设置主题

<img src="https://doc-1314952491.cos.ap-shanghai.myqcloud.com/obsidian/Pasted%20image%2020230914235412.png" class="m-auto h-90" />

---

设置字体：工具-选项-Environment-字体和颜色

<img src="https://doc-1314952491.cos.ap-shanghai.myqcloud.com/obsidian/Pasted%20image%2020230914235520.png" class="m-auto h-90" />


这里可以进行非常详细的设定，具体自行百度。

推荐一款字体：[霞鹜文楷](https://github.com/lxgw/LxgwWenKai)，在编辑器中使用其等宽版本：霞鹜文楷等宽