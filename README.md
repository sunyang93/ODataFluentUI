# OData驱动的UI
## 1 摘要
一切源于[REST](https://www.ics.uci.edu/~fielding/pubs/dissertation/rest_arch_style.htm)原则的伟大愿景。遵循REST原则定义的所有资源都应该是自描述的，资源本身包含操作(CRUD)该资源的所有寻址信息。

[OData](https://www.odata.org/)是一种**开放协议**，允许以**简单**和标准的方式创建和使用可查询**和**可互操作的 RESTful API。

## 2 目录

## 3 REST介绍
REST是**RE**presentational **S**tate **T**ransfer`表述性状态转移` 的首字母缩写。它是**分布式超媒体系统的**架构风格，最初由Roy Fielding在2000年的着名[论文](https://www.ics.uci.edu/~fielding/pubs/dissertation/rest_arch_style.htm)中提出。

### 3.1 REST的指导原则
1.  **客户端 - 服务器** - 通过将用户接口问题与数据存储问题分开，我们通过简化服务器组件来提高跨多个平台的用户接口的可移植性并提高可伸缩性。
2.  **无状态** - 从客户端到服务器的每个请求都必须包含理解请求所需的所有信息，并且不能利用服务器上任何存储的上下文。因此，会话状态完全保留在客户端上。
3.  **可缓存** - 缓存约束要求将对请求的响应中的数据隐式或显式标记为可缓存或不可缓存。如果响应是可缓存的，则客户端缓存有权重用该响应数据以用于以后的等效请求。
4.  **统一接口** - 通过将通用性的软件工程原理应用于组件接口，简化了整个系统架构，提高了交互的可见性。为了获得统一的接口，需要多个架构约束来指导组件的行为。REST由四个接口约束定义：资源识别; 通过陈述来处理资源; 自我描述性的信息; 并且，超媒体作为应用程序状态的引擎。
5.  **分层系统** - 分层系统风格允许通过约束组件行为来使体系结构由分层层组成，这样每个组件都不能“看到”超出与它们交互的直接层。
6.  **按需编码（可选）** - REST允许通过以小程序或脚本的形式下载和执行代码来扩展客户端功能。这通过减少预先实现所需的功能数量来简化客户端。

### 3.2 推荐阅读
[REST on Wikipedia][rest-on-wikipedia] -- REST 背后的常见定义和核心思想概述。

[REST Dissertation][fielding] -- Roy Fielding 关于网络架构的论文“架构风格和基于网络的软件架构的设计”中关于 REST 的章节

## 4 OData介绍
OData（开放数据协议）是[ISO/IEC 批准](https://www.oasis-open.org/news/pr/iso-iec-jtc-1-approves-oasis-odata-standard-for-open-data-exchange)的[OASIS 标准](https://www.oasis-open.org/committees/tc_home.php?wg_abbrev=odata)，它定义了一组用于构建和使用 RESTful API 的最佳实践。OData 帮助您在构建 RESTful API 时专注于业务逻辑，而不必担心定义请求和响应标头、状态代码、HTTP 方法、URL 约定、媒体类型、有效负载格式、查询选项等的各种方法。OData 还提供跟踪更改、定义可重用过程的功能/操作以及发送异步/批处理请求的指南。

OData RESTful API 易于使用。OData 元数据是 API 数据模型的机器可读描述，支持创建功能强大的通用客户端代理和工具。

## 5 功能介绍
### 5.1 数据驱动的UI
### 5.2 可自定义的Entity
### 5.3 可视化的Entity依赖关系图
### 4 灵活的数据整形

