# isc包

当前针对版本1.7.0

# 计划功能
## 资源目录
###	区域信息
### 人员信息
#### 人员卡片接口
1. 批量开卡 `IHikCardManager.BindingAsync`
2. 卡片退卡 `IHikCardManager.DeletionAsync`
3. 批量挂失 `IHikCardManager.AddLossAsync`
4. 批量解挂 `IHikCardManager.DeleteLossAsync`
5. 生成卡片二维码 `IHikCardManager.GenerateBarCodeAsync`
6. 获取卡片列表 `IHikCardManager.GetListAsync`
7. 获取单个卡片信息 `IHikCardManager.GetInfoAsync`
8. 查询卡片列表 `IHikCardManager.GetListByParametersAsync`
9. 增量获取卡片数据 `IHikCardManager.GetListByTimeRangeAsync`

#### 组织信息接口
1. 修改组织 `IHikOrgManager.UpdateAsync`
2. 批量删除组织 `IHikOrgManager.BatchDeleteAsync`
3. 批量添加组织 `IHikOrgManager.BatchAddAsync`
4. 获取根组织 `IHikOrgManager.GetRootAsync`
5. 获取组织列表 `IHikOrgManager.GetListAsync`
6. 查询组织列表v2 `IHikOrgManager.GetListByParametersV2Async`
7. 根据父组织编号获取下级组织列表 `IHikOrgManager.GetSubListAsync`
8. 增量获取组织数据 `IHikOrgManager.GetListByTimeRangeAsync`
9. 根据组织编号获取组织详细信息 `IHikOrgManager.GetListByIndexCodesAsync`

#### 人员及照片接口
1. 获取资源属性 `IHikResourceManager.GetPropertiesAsync`
2. 添加人员v2 `IHikPersonManager.AddV2Async`
3. 批量添加人员 `IHikPersonManager.BatchAddAsync`
4. 修改人员 `IHikPersonManager.UpdateAsync`
5. 批量删除人员 `IHikPersonManager.BatchDeleteAsync`
6. 添加人脸 `IHikFaceManager.AddAsync`
7. 修改人脸 `IHikFaceManager.UpdateAsync`
8. 删除人脸 `IHikFaceManager.DeleteAsync`
9. 获取组织下人员列表v2 `IHikPersonManager.GetListByOrgV2Async`
10. 获取人员列表v2 `IHikPersonManager.GetListV2Async`
11. 查询人员列表v2 `IHikPersonManager.GetListByParametersV2Async`
12. 根据人员唯一字段获取人员详细信息 `IHikPersonManager.GetDetailListAsync`
13. 增量获取人员数据 `IHikPersonManager.GetListByTimeRangeAsync`
14. 提取人员图片 `IHikPersonManager.GetPictureAsync`

###	 资源信息
###	 设备网管服务
1. 获取资源的历史在线记录 `IHikResourceManager.GetOnlineHistoryAsync`

##  视频应用服务
##  一卡通应用服务
##  车辆管控
##  报警监测
##  人脸应用服务
##  事件服务
##  测温应用

# 版本历史
## 0.3.0
### ManagersV2
 * [更新] `IHikResourceManager`
 
### Dictionaries [删除]
 * [删除] `DoorEventSortCollection`
 * [删除] `IDoorEventSortCollection`
 * [删除] `EventCollection`
 * [删除] `IEventCollection`
 * [删除] `EventCollectionItem`
 * [删除] `InstallLocationCollection`
 * [删除] `IInstallLocationCollection`
 * [删除] `PlanStatusCollection`
 * [删除] `IPlanStatusCollection`
	

======================================
## 0.2.0.220613
 * [新增] `HikCardManager`
 * [新增] `HikFaceManager`
 * [新增] `HikOrgManager`
 * [新增] `HikPersonManager`
 * [新增] `HikResourceManager`

======================================