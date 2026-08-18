# C# Technical Round — 1,000 Hands-On Interview Questions

> Practical technical-round workbook for C# developers from beginner level through senior/lead interviews (up to ~8 years of experience).

## How to use this workbook

- Treat every item as a coding/debugging/design exercise, not a theory-only question.
- For junior rounds, prioritize Sections 1–8 and write working code without LINQ first when requested.
- For mid-level rounds, prioritize Sections 9–16 and explain complexity, memory use, failure handling, and testability.
- For senior/lead rounds, prioritize Sections 17–20 and be prepared to justify trade-offs, concurrency, performance, reliability, and architecture.
- For each problem, aim to provide: working code, edge cases, time complexity, space complexity, and a short production-oriented explanation.

## Coverage

- **01. C# Fundamentals & Syntax** — Questions 1–50
- **02. Strings, Characters & Text Processing** — Questions 51–100
- **03. Arrays, Collections & Algorithms** — Questions 101–152
- **04. Dictionaries, Hashing, Stack & Queue Problems** — Questions 153–203
- **05. OOP, Classes, Structs & Encapsulation** — Questions 204–254
- **06. Exceptions, Validation & Resource Management** — Questions 255–304
- **07. Generics, Delegates, Events & Functional C#** — Questions 305–354
- **08. LINQ & Collections Pipelines** — Questions 355–405
- **09. Advanced LINQ, Expression Trees & Query Composition** — Questions 406–455
- **10. Delegates, Reflection, Attributes & Dynamic** — Questions 456–504
- **11. Async/Await, Tasks & Cancellation** — Questions 505–554
- **12. Parallelism, Threads, Locks & Concurrency** — Questions 555–604
- **13. Memory, GC, Span, Memory & Performance** — Questions 605–654
- **14. File I/O, Serialization, Streams & Networking Basics** — Questions 655–705
- **15. Dependency Injection, Configuration & Application Architecture** — Questions 706–755
- **16. Unit Testing, Mocking & Testability** — Questions 756–806
- **17. C# Modern Language Features & Source-Oriented Coding** — Questions 807–857
- **18. Unsafe, Interop & Advanced Runtime Exercises** — Questions 858–907
- **19. Distributed Systems, Reliability & Production-Grade C#** — Questions 908–957
- **20. Senior/Lead (5-8 Years): Architecture, Diagnostics, Coding & System Scenarios** — Questions 958–1000

---

## 01. C# Fundamentals & Syntax

1. Write a program that reads two integers and prints their sum, difference, product, quotient, and remainder.

2. Write a method that swaps two integers using a temporary variable.

3. Write a method that swaps two integers without using a temporary variable.

4. Write a program that determines whether an integer is even or odd.

5. Write a program that checks whether a number is positive, negative, or zero.

6. Write a method that returns the maximum of two integers without using Math.Max.

7. Write a method that returns the maximum of three integers using conditional operators.

8. Write a method that calculates factorial iteratively.

9. Write a method that calculates factorial recursively.

10. Write a method that calculates the nth Fibonacci number iteratively.

11. Write a method that generates the first N Fibonacci numbers.

12. Write a method that checks whether a number is prime.

13. Write a program that prints all prime numbers in a given range.

14. Write a method that counts the digits in an integer without converting it to a string.

15. Write a method that reverses an integer while preserving its sign.

16. Write a method that checks whether an integer is a palindrome.

17. Write a method that calculates the sum of digits of an integer.

18. Write a method that calculates the product of digits of an integer.

19. Write a method that calculates the GCD of two integers.

20. Write a method that calculates the LCM of two integers.

21. Write a program that prints all Armstrong numbers in a given range.

22. Write a method that checks whether a number is an Armstrong number.

23. Write a method that checks whether a number is a perfect number.

24. Write a method that prints all divisors of an integer.

25. Write a method that counts how many times a digit occurs in an integer.

26. Write a console program that converts Celsius to Fahrenheit and Kelvin.

27. Write a menu-driven calculator using switch expressions.

28. Write a method that validates whether a year is a leap year.

29. Write a program that prints a right-aligned triangle of stars.

30. Write a program that prints a centered pyramid of stars.

31. Write a program that prints Floyd's triangle.

32. Write a program that prints a multiplication table for a given number.

33. Write a method that computes x raised to the power n without Math.Pow.

34. Write a method that computes x^n efficiently using exponentiation by squaring.

35. Write a method that returns the average of an integer array without integer division.

36. Write a method that converts a decimal integer to binary without Convert.ToString.

37. Write a method that converts a binary string to an integer without Convert.ToInt32.

38. Write a method that checks whether a given bit is set in an integer.

39. Write methods to set, clear, toggle, and test a specific bit.

40. Write a method that counts the number of set bits in an integer.

41. Write a method that determines whether an integer is a power of two.

42. Write a method that finds the smallest power of two greater than or equal to N.

43. Write a program demonstrating checked versus unchecked integer overflow.

44. Write examples showing implicit and explicit numeric conversions.

45. Write a method using optional parameters and demonstrate its behavior.

46. Write a method using named arguments and demonstrate multiple call orders.

47. Write a method with a params parameter and calculate the total of all inputs.

48. Write a generic method that returns the default value for any type.

49. Write a program demonstrating expression-bodied methods and properties.

50. Write a method that uses pattern matching to classify an object value.

## 02. Strings, Characters & Text Processing

51. Write a method that reverses a string without Reverse().

52. Write a method that reverses the words in a sentence while preserving word order.

53. Write a method that reverses the order of words in a sentence.

54. Write a method that checks whether a string is a palindrome.

55. Write a method that counts vowels, consonants, digits, and whitespace characters.

56. Write a method that counts occurrences of each character using a dictionary.

57. Write a method that returns the first non-repeating character.

58. Write a method that returns the first repeated character.

59. Write a method that removes duplicate characters while preserving first occurrence.

60. Write a method that checks whether two strings are anagrams.

61. Write a method that groups a list of words into anagram groups.

62. Write a method that finds the longest word in a sentence.

63. Write a method that finds the shortest word in a sentence.

64. Write a method that counts the number of words without Split().

65. Write a tokenizer that separates words, punctuation, and numbers.

66. Write a method that converts a sentence to title case without TextInfo.

67. Write a method that converts camelCase to snake_case.

68. Write a method that converts snake_case to PascalCase.

69. Write a method that validates balanced parentheses, brackets, and braces in a string.

70. Write a method that finds the longest substring without repeating characters.

71. Write a method that finds the longest palindromic substring using brute force.

72. Write a method that checks whether one string is a rotation of another.

73. Write a method that implements substring search without IndexOf.

74. Write a method that implements a basic KMP-style substring search.

75. Write a method that replaces repeated whitespace with a single space.

76. Write a method that parses a CSV row while respecting quoted commas.

77. Write a method that masks all but the last four digits of an identifier.

78. Write a method that masks an email address for display.

79. Write a method that validates a simple email format using a regular expression.

80. Write a method that extracts URLs from a block of text.

81. Write a method that extracts hashtags from a social-media-style sentence.

82. Write a method that removes HTML tags from a string using a safe parsing approach.

83. Write a method that HTML-encodes dangerous characters without external libraries.

84. Write a method that counts words case-insensitively.

85. Write a method that compares two strings using ordinal, ordinal-ignore-case, and culture-aware comparison.

86. Write a program demonstrating why string is immutable.

87. Write a benchmark-style program comparing string concatenation and StringBuilder.

88. Write a method that efficiently builds a large string using StringBuilder.

89. Write a method that joins strings without string.Join.

90. Write a method that splits a string by multiple separators.

91. Write a method that parses an integer manually and handles invalid input.

92. Write a method that parses a decimal money value using TryParse and culture.

93. Write a method that normalizes Unicode text before comparison.

94. Write a method that performs a case-insensitive dictionary lookup correctly.

95. Write a method that checks whether a string contains only ASCII characters.

96. Write a method that checks whether a string contains only digits without LINQ.

97. Write a method that compresses consecutive repeated characters such as aaabbc -> a3b2c1.

98. Write a method that decompresses a simple run-length encoded string.

99. Write a method that rotates a string left by K positions.

100. Write a method that finds all starting indices of a pattern in a string.

## 03. Arrays, Collections & Algorithms

101. Find the maximum element in an integer array without LINQ.

102. Find the minimum element in an integer array without LINQ.

103. Find the second-largest distinct element in an array.

104. Find the second-smallest distinct element in an array.

105. Reverse an array in place.

106. Rotate an array left by K positions.

107. Rotate an array right by K positions.

108. Move all zeros to the end while preserving non-zero order.

109. Move all negative numbers to one side of an array.

110. Remove duplicates from a sorted array in place.

111. Merge two sorted arrays into one sorted array.

112. Find the intersection of two integer arrays.

113. Find the union of two integer arrays.

114. Find the missing number from 0..N.

115. Find all missing numbers from 1..N.

116. Find the duplicate number when exactly one value is duplicated.

117. Find all duplicate values in an array.

118. Find the majority element occurring more than N/2 times.

119. Find all elements occurring more than N/3 times.

120. Find the top K largest elements.

121. Find the top K smallest elements.

122. Find the Kth largest element using a heap.

123. Find the Kth largest element using quickselect.

124. Implement binary search iteratively.

125. Implement binary search recursively.

126. Find the first occurrence of a target in a sorted array.

127. Find the last occurrence of a target in a sorted array.

128. Find the insertion position of a target in a sorted array.

129. Find a peak element in an array.

130. Find the maximum subarray sum using Kadane's algorithm.

131. Return the actual subarray that produces the maximum sum.

132. Find the maximum product subarray.

133. Find the shortest subarray with sum at least K.

134. Find all pairs that sum to a target.

135. Find all unique triplets that sum to zero.

136. Find the pair whose sum is closest to a target.

137. Find the longest consecutive sequence.

138. Find the longest increasing contiguous subarray.

139. Find the length of the longest increasing subsequence.

140. Merge overlapping intervals.

141. Insert and merge a new interval into sorted intervals.

142. Find whether intervals overlap.

143. Find the number of meeting rooms required for intervals.

144. Implement an array-backed stack.

145. Implement an array-backed queue.

146. Implement a circular queue.

147. Implement a min stack supporting O(1) minimum lookup.

148. Implement a queue using two stacks.

149. Implement a stack using two queues.

150. Implement a singly linked list with insert, delete, and search.

151. Reverse a singly linked list iteratively.

152. Reverse a singly linked list recursively.

## 04. Dictionaries, Hashing, Stack & Queue Problems

153. Count word frequencies using Dictionary<string,int>.

154. Return the key with the highest frequency in a dictionary.

155. Group records by a composite key using a dictionary.

156. Implement a dictionary-style cache with expiration timestamps.

157. Implement a simple hash table with separate chaining.

158. Implement a simple hash table with open addressing.

159. Explain and demonstrate collision handling in a custom hash table.

160. Implement an LRU cache using Dictionary and LinkedList.

161. Implement an LFU cache using dictionaries and linked lists.

162. Implement a fixed-size FIFO cache.

163. Implement a browser history using stacks.

164. Implement undo/redo using two stacks.

165. Evaluate a postfix expression using a stack.

166. Convert infix expression to postfix.

167. Evaluate an expression containing +, -, *, /, and parentheses.

168. Find the next greater element for each array position.

169. Find the previous greater element for each array position.

170. Find the next smaller element for each array position.

171. Find the daily temperatures waiting time using a monotonic stack.

172. Find the largest rectangle in a histogram.

173. Find the largest rectangle of 1s in a binary matrix.

174. Validate nested HTML-like tags using a stack.

175. Implement a queue using LinkedList<T>.

176. Implement a priority queue from scratch using a binary heap.

177. Implement a max heap from scratch.

178. Implement a min heap from scratch.

179. Implement heap sort.

180. Implement quicksort.

181. Implement mergesort.

182. Implement insertion sort.

183. Implement selection sort.

184. Implement bubble sort and explain its optimization.

185. Sort an array containing only 0, 1, and 2 in one pass.

186. Find the median of two sorted arrays.

187. Find running median from a stream of integers.

188. Find K closest points to the origin.

189. Find K most frequent elements.

190. Find the smallest range covering elements from K sorted lists.

191. Merge K sorted linked lists.

192. Design a thread-safe bounded queue API.

193. Design a blocking queue API.

194. Design a producer-consumer queue using Monitor.

195. Implement producer-consumer using SemaphoreSlim.

196. Implement a work queue with a configurable worker count.

197. Build a retry queue that moves failed items to a dead-letter collection.

198. Create a duplicate-request detector using a hash set.

199. Implement a sliding-window rate counter using a queue.

200. Implement a TTL set using timestamps and a priority queue.

201. Implement a top-K tracker for an event stream.

202. Implement a rolling average using a queue.

203. Implement a rolling median using two heaps.

## 05. OOP, Classes, Structs & Encapsulation

204. Create a Customer class with validation in its constructor.

205. Implement a bank account with encapsulated balance changes.

206. Create an immutable Money type.

207. Create an immutable Address type using a record.

208. Implement a class with a private setter and controlled state transitions.

209. Demonstrate constructor chaining with multiple constructors.

210. Implement a base class and derived class showing method overriding.

211. Demonstrate method hiding with new and explain the runtime behavior.

212. Create an abstract Shape class and implement Circle, Rectangle, and Triangle.

213. Create an interface-based notification system with Email, SMS, and Push implementations.

214. Use dependency injection through constructor parameters in a small domain service.

215. Create a sealed class and demonstrate why further inheritance fails.

216. Create a static utility class and explain its trade-offs.

217. Create a nested class and demonstrate access to the outer type's private members.

218. Implement a custom value object using equality semantics.

219. Implement IEquatable<T> for a domain entity.

220. Override Equals and GetHashCode correctly for a value object.

221. Create a class whose objects are immutable after construction.

222. Create a mutable class and demonstrate reference aliasing bugs.

223. Demonstrate shallow copy versus deep copy for a nested object graph.

224. Implement ICloneable-style deep cloning without ICloneable.

225. Create a copy constructor for a class.

226. Create a base repository abstraction and two implementations.

227. Model an order with Order, OrderLine, Product, and Customer classes.

228. Prevent invalid state transitions in an Order aggregate.

229. Implement polymorphic pricing rules using an interface.

230. Implement a strategy pattern for discount calculation.

231. Implement a factory for payment providers.

232. Implement a factory method for creating domain objects.

233. Implement a builder for constructing a complex report configuration.

234. Implement a fluent API for configuring a request.

235. Implement a specification pattern for filtering customers.

236. Implement a composite pattern for nested categories.

237. Implement decorator-based logging around a service.

238. Implement adapter pattern for two incompatible payment APIs.

239. Implement bridge pattern for notifications across channels.

240. Implement command objects for order operations.

241. Implement a simple mediator abstraction without a third-party library.

242. Create a domain event class and handler architecture.

243. Create a class hierarchy and refactor it to composition.

244. Demonstrate Liskov Substitution Principle violation and fix it.

245. Demonstrate Interface Segregation Principle with a poorly designed interface and refactor it.

246. Demonstrate Dependency Inversion Principle using abstractions.

247. Refactor a god class into cohesive services.

248. Refactor a class with too many constructor dependencies.

249. Implement a thread-safe singleton and compare approaches.

250. Implement a lazy singleton using Lazy<T>.

251. Create a struct for a small immutable value and compare it with a class.

252. Create a readonly struct and explain boxing behavior.

253. Create a record class and compare equality with a regular class.

254. Create a record struct and compare it with a readonly struct.

## 06. Exceptions, Validation & Resource Management

255. Create a custom exception for invalid order state.

256. Create a validation exception that contains multiple field errors.

257. Write a method that uses try/catch/finally correctly.

258. Demonstrate exception filters with when.

259. Write code that rethrows an exception while preserving the original stack trace.

260. Demonstrate the difference between throw and throw ex.

261. Create a custom exception hierarchy for a payment domain.

262. Wrap a low-level exception with a domain-specific exception while preserving the inner exception.

263. Implement argument validation with ArgumentNullException.ThrowIfNull.

264. Implement validation for a method accepting a range of numeric values.

265. Create a validation pipeline for a request object.

266. Collect multiple validation errors before throwing.

267. Implement IDisposable for a class holding an unmanaged-like resource wrapper.

268. Implement the full IDisposable pattern for an inheritable class.

269. Implement a sealed IDisposable class with a simple Dispose method.

270. Use using declarations to dispose resources.

271. Use await using with an IAsyncDisposable resource.

272. Create a class implementing both IDisposable and IAsyncDisposable.

273. Demonstrate why finalizers should be avoided unless required.

274. Create a SafeHandle-based resource wrapper.

275. Implement a retry helper that retries only transient exceptions.

276. Implement exponential backoff with jitter for retries.

277. Implement a timeout wrapper around an operation.

278. Implement a circuit breaker without external libraries.

279. Implement a fallback mechanism for a failing dependency.

280. Create a global exception-handling abstraction for console applications.

281. Write a helper that preserves cancellation exceptions instead of swallowing them.

282. Write tests that verify a method throws a specific exception.

283. Create a Result<T> type instead of using exceptions for expected failures.

284. Implement Either/Result-style success and failure in plain C#.

285. Create a validation result type that contains a success flag and errors.

286. Handle malformed JSON without crashing the entire batch.

287. Process 10,000 inputs and continue after per-item exceptions.

288. Capture failed items and their exceptions into a dead-letter list.

289. Implement a safe parser using TryParse-style APIs.

290. Create a helper that converts exceptions into error codes.

291. Create an exception logging helper that includes context but no secrets.

292. Implement a method that times out and disposes its linked resources.

293. Build a file processor that always closes files after failure.

294. Build a network-resource wrapper that cleans up correctly.

295. Create a custom exception with serialization-friendly properties.

296. Demonstrate the dangers of catching Exception broadly.

297. Show how exception filters can prevent expensive catch blocks.

298. Implement a retry helper with a maximum elapsed duration.

299. Implement a retry helper that stops on cancellation.

300. Implement a timeout helper using CancellationToken.

301. Build an exception aggregation utility for parallel operations.

302. Implement a batch executor that reports partial failures.

303. Write code that distinguishes validation, transient, and fatal errors.

304. Review a deliberately broken exception-handling method and refactor it.

## 07. Generics, Delegates, Events & Functional C#

305. Write a generic Swap<T> method.

306. Write a generic Max<T> method using IComparable<T>.

307. Write a generic Min<T> method.

308. Write a generic Clamp<T> method.

309. Write a generic method that returns the first matching item using a predicate.

310. Create a generic repository interface.

311. Create a generic in-memory repository implementation.

312. Constrain a generic type to classes and demonstrate the effect.

313. Constrain a generic type to structs.

314. Constrain a generic type to new() and construct instances.

315. Use multiple generic constraints in one method.

316. Implement a generic cache with TTL support.

317. Create a generic Pair<T1,T2> type.

318. Create a generic Result<T> type with success/failure state.

319. Implement a generic object pool.

320. Implement a generic circular buffer.

321. Implement a generic binary heap.

322. Implement a generic priority queue.

323. Create a generic method that accepts a comparer.

324. Create a generic method that accepts an equality comparer.

325. Write a method using Action<T>.

326. Write a method using Func<T,TResult>.

327. Write a method using Predicate<T>.

328. Create a custom delegate type and use it.

329. Build a pipeline from a list of Func<T,T> delegates.

330. Create a retry pipeline using delegates.

331. Create a validation pipeline using delegates.

332. Implement a multicast delegate and demonstrate invocation order.

333. Create a delegate that can be combined and removed.

334. Create a custom event using EventHandler<TEventArgs>.

335. Create an event publisher and subscriber and unsubscribe safely.

336. Demonstrate why event handlers can cause memory leaks.

337. Create a weak-event-like pattern for a simple use case.

338. Implement a callback-based asynchronous API.

339. Refactor a callback API to Task-based async.

340. Implement a higher-order function that composes two functions.

341. Implement function composition for three functions.

342. Write a generic memoization function.

343. Write a memoized recursive Fibonacci function.

344. Implement a generic lazy value using Func<T>.

345. Implement a once-only action wrapper.

346. Implement a throttled delegate wrapper.

347. Implement a debounced delegate wrapper.

348. Write an extension method that filters a collection.

349. Write an extension method that chunks a sequence.

350. Write an extension method that safely gets a dictionary value.

351. Write an extension method for null-safe string operations.

352. Write a generic extension method for batching items.

353. Create an extension method that materializes an IEnumerable only once.

354. Demonstrate closure capture bugs in loops and fix them.

## 08. LINQ & Collections Pipelines

355. Select only even numbers from an integer list.

356. Select squares of numbers using LINQ.

357. Filter customers by age and status.

358. Sort objects by multiple fields.

359. Group employees by department.

360. Group employees by department and job title.

361. Find the highest salary in each department.

362. Find the second-highest salary in each department.

363. Find duplicate emails using LINQ.

364. Find unique emails using LINQ.

365. Find the first non-repeating character using LINQ.

366. Find the most frequent word in a sentence using LINQ.

367. Flatten nested collections with SelectMany.

368. Join customers and orders with Join.

369. Perform a left outer join between customers and orders.

370. Perform a group join and calculate order counts.

371. Compare two sequences for equality.

372. Find items present in one sequence but not another.

373. Find common items between two sequences.

374. Partition a list into chunks of N.

375. Implement chunking manually without Enumerable.Chunk.

376. Implement DistinctBy manually.

377. Find the top 3 products per category.

378. Find the latest record per customer.

379. Find the earliest record per customer.

380. Find records whose value is above their group's average.

381. Find employees earning above their department average.

382. Calculate a running total with LINQ.

383. Calculate a moving average.

384. Create a LINQ pipeline that filters, projects, groups, and aggregates data.

385. Convert a flat list to a hierarchical tree using LINQ.

386. Convert a hierarchy back to a flat list.

387. Build a lookup from a sequence.

388. Build a dictionary with duplicate-key handling.

389. Use Aggregate to implement a custom reduction.

390. Use Zip to compare corresponding elements.

391. Use Any, All, Contains, and SequenceEqual in practical filters.

392. Demonstrate deferred execution with a changing source collection.

393. Demonstrate multiple enumeration and fix it.

394. Show the difference between IEnumerable and IQueryable in a small example.

395. Create a method that accepts IEnumerable<T> and preserves deferred execution.

396. Create an iterator method using yield return.

397. Create a recursive tree iterator using yield return.

398. Create an async iterator using IAsyncEnumerable<T>.

399. Use await foreach to consume an async stream.

400. Implement custom LINQ-like Where and Select extensions.

401. Implement custom OrderBy for a small educational example.

402. Implement a custom GroupBy for an educational example.

403. Implement pagination with Skip and Take.

404. Implement cursor-style pagination over an in-memory sequence.

405. Review a LINQ query that is correct but inefficient and optimize it.

## 09. Advanced LINQ, Expression Trees & Query Composition

406. Build a dynamic predicate using Expression<Func<T,bool>>.

407. Combine two expression predicates with AND.

408. Combine two expression predicates with OR.

409. Negate an expression predicate.

410. Replace one parameter expression with another.

411. Build an expression that filters by a property name supplied as a string.

412. Build a dynamic OrderBy expression for a property name.

413. Build a dynamic ThenBy expression.

414. Build a dynamic Select projection with an expression tree.

415. Build a generic expression for equality against a constant value.

416. Build a generic expression for Contains on a collection.

417. Build a generic expression for string StartsWith.

418. Build a generic expression for string Contains.

419. Build a dynamic range predicate such as Min <= property <= Max.

420. Convert a list of filter DTOs into a combined expression tree.

421. Create a small specification evaluator over IQueryable<T>.

422. Create a reusable specification base class.

423. Compose nested specifications without third-party libraries.

424. Create an expression visitor that replaces parameters.

425. Create an expression visitor that counts property accesses.

426. Create an expression visitor that rewrites equality to case-insensitive string comparison.

427. Inspect and print an expression tree structure.

428. Compile an expression tree and compare it with a normal delegate.

429. Create a dynamic query builder for multiple optional filters.

430. Create a dynamic sort builder with ascending/descending directions.

431. Build a dynamic pagination expression.

432. Build a reusable projection expression from Order to OrderDto.

433. Compose reusable projection expressions.

434. Implement a Queryable extension that applies a dynamic filter.

435. Implement a Queryable extension that applies dynamic sorting.

436. Demonstrate a case where Enumerable and Queryable produce different behavior.

437. Write a query that accidentally switches from IQueryable to IEnumerable and fix it.

438. Demonstrate client-side evaluation risks in data-access LINQ.

439. Build an async query pipeline over IQueryable.

440. Create a reusable query object containing expression, sort, and pagination.

441. Create a generic filter builder supporting string, numeric, date, and nullable properties.

442. Implement nested-property filtering such as Customer.Address.City.

443. Implement collection-property filtering such as Orders.Any(...).

444. Build an OR filter over multiple search terms.

445. Build a full-text-like search predicate over several fields.

446. Build a dynamic projection returning anonymous-like DTO objects.

447. Measure the cost of compiling expression trees repeatedly and cache compiled expressions.

448. Implement expression caching using ConcurrentDictionary.

449. Build a small rules engine using expression trees.

450. Implement a predicate parser for a limited filter syntax.

451. Implement a dynamic calculator using expression trees.

452. Build a safe expression whitelist that rejects unsupported nodes.

453. Explain and demonstrate why arbitrary expression compilation can be dangerous.

454. Create tests for dynamic LINQ expressions.

455. Refactor a deeply nested LINQ query into readable reusable query operators.

## 10. Delegates, Reflection, Attributes & Dynamic

456. Use reflection to list all public properties of a type.

457. Use reflection to list all methods declared on a type.

458. Find properties marked with a custom attribute.

459. Create a custom attribute for validation metadata.

460. Read constructor metadata with reflection.

461. Instantiate a type using Activator.CreateInstance.

462. Invoke a method by name using reflection.

463. Read and write a property dynamically using reflection.

464. Call a generic method dynamically.

465. Find all implementations of an interface in a loaded assembly.

466. Create a simple dependency registrar using reflection.

467. Scan an assembly for classes carrying a custom attribute.

468. Build a plugin loader that discovers types implementing an interface.

469. Load a plugin assembly from a file path.

470. Create a plugin contract and sample plugin implementation.

471. Implement a lightweight command dispatcher using attributes.

472. Create attribute-based routing metadata.

473. Build a method invoker that reads route attributes.

474. Build a simple serializer-like mapper using reflection.

475. Map one object type to another by matching property names.

476. Handle nullable and incompatible property types in the mapper.

477. Cache reflected PropertyInfo metadata.

478. Compile property getters using expression trees.

479. Compile property setters using expression trees.

480. Compare reflection invocation with compiled delegates.

481. Build a simple dependency injection container using reflection.

482. Support constructor injection in the custom DI container.

483. Support singleton and transient lifetimes in the custom container.

484. Detect circular dependencies in the custom DI container.

485. Support open generic registrations in the custom DI container.

486. Create a service factory using IServiceProvider-like semantics.

487. Demonstrate runtime type inspection with pattern matching.

488. Use dynamic to call a member discovered at runtime.

489. Demonstrate the runtime binding failure behavior of dynamic.

490. Create a method that accepts object and uses reflection-based dispatch.

491. Create a mini object mapper that supports nested objects.

492. Create a mini object mapper that supports collections.

493. Implement custom attribute inheritance behavior.

494. Create a command registry keyed by enum or string.

495. Use MethodInfo.CreateDelegate for efficient invocation.

496. Implement a reflection-based validator.

497. Build a reflection-based CSV exporter.

498. Build a reflection-based table formatter.

499. Write a metadata cache that is thread-safe.

500. Create a runtime proxy-like wrapper using DispatchProxy.

501. Build logging behavior around an interface using DispatchProxy.

502. Build a generic interceptor with DispatchProxy.

503. Explain and demonstrate trimming/AOT concerns with reflection-heavy code.

504. Write a reflection scanner that avoids repeated assembly enumeration.

## 11. Async/Await, Tasks & Cancellation

505. Write an async method that delays without blocking the thread.

506. Convert a synchronous file-read method to async.

507. Convert a synchronous stream-copy method to async.

508. Run two independent asynchronous operations concurrently.

509. Use Task.WhenAll to aggregate results.

510. Use Task.WhenAny to return the first completed result.

511. Cancel an async operation using CancellationToken.

512. Create a timeout using CancellationTokenSource.CancelAfter.

513. Combine an external cancellation token with a timeout.

514. Implement a cancellable delay loop.

515. Write a method that cooperatively checks cancellation.

516. Handle OperationCanceledException correctly.

517. Demonstrate why async void should generally be avoided.

518. Convert an event-based async pattern to Task.

519. Create TaskCompletionSource for a custom async wait.

520. Configure TaskCompletionSource with RunContinuationsAsynchronously and explain why.

521. Implement an async lock using SemaphoreSlim.

522. Implement an AsyncAutoResetEvent from scratch.

523. Implement an AsyncManualResetEvent from scratch.

524. Implement an async semaphore with fairness considerations.

525. Implement an asynchronous rate limiter.

526. Implement an asynchronous producer-consumer pipeline using Channels.

527. Process a large stream using IAsyncEnumerable<T>.

528. Implement an async iterator that supports cancellation.

529. Use Parallel.ForEachAsync to process many items.

530. Limit concurrency when processing a batch.

531. Build an async worker pool.

532. Build a fan-out/fan-in async pipeline.

533. Build an async retry helper.

534. Build an async circuit breaker.

535. Build an async timeout wrapper.

536. Build a method that returns partial results when some tasks fail.

537. Capture individual task exceptions without failing the whole batch.

538. Create a task that completes when an event occurs.

539. Create a cancellable event-to-task bridge.

540. Demonstrate SynchronizationContext-related deadlock in a controlled example.

541. Explain and demonstrate why .Result or .Wait can deadlock in UI/request environments.

542. Demonstrate ConfigureAwait(false) in a library-style method.

543. Create an async method that accidentally blocks and refactor it.

544. Detect sequential awaits that could run concurrently.

545. Benchmark sequential versus concurrent I/O operations.

546. Write a method that limits concurrency with SemaphoreSlim.

547. Implement a batch processor with max degree of parallelism.

548. Implement cancellation cascading across child operations.

549. Create a linked CancellationTokenSource hierarchy.

550. Implement graceful shutdown for async workers.

551. Write an async method with proper disposal using await using.

552. Handle cancellation during channel reads.

553. Implement an async polling loop with backoff and cancellation.

554. Review and fix an async method containing common anti-patterns.

## 12. Parallelism, Threads, Locks & Concurrency

555. Create a simple Thread that executes a worker method.

556. Use Thread.Join to wait for completion.

557. Demonstrate a race condition on a shared counter.

558. Fix the counter race using lock.

559. Fix the counter race using Interlocked.Increment.

560. Compare lock and Interlocked in a benchmark.

561. Protect a Dictionary from concurrent access.

562. Use ConcurrentDictionary for atomic updates.

563. Use GetOrAdd correctly with ConcurrentDictionary.

564. Demonstrate the factory delegate multiple-execution caveat in GetOrAdd.

565. Create a thread-safe singleton.

566. Implement double-checked locking correctly.

567. Demonstrate deadlock with two locks and fix lock ordering.

568. Create a Monitor-based critical section.

569. Use Monitor.Wait and Pulse for producer-consumer coordination.

570. Use ManualResetEventSlim for signaling.

571. Use AutoResetEvent for worker signaling.

572. Use CountdownEvent to coordinate multiple workers.

573. Use Barrier to synchronize phases.

574. Use ReaderWriterLockSlim for read-heavy data.

575. Demonstrate upgradeable read locks.

576. Demonstrate lock recursion restrictions.

577. Implement a thread-safe bounded buffer.

578. Implement a lock-free stack using Interlocked.

579. Implement a lock-free counter.

580. Implement a spin-based lock for educational purposes.

581. Explain and demonstrate memory visibility with volatile.

582. Create a thread-safe lazy initialization.

583. Partition work across multiple threads and aggregate results.

584. Use Parallel.For for CPU-bound processing.

585. Use Parallel.ForEach with cancellation.

586. Use ParallelOptions to limit parallelism.

587. Handle exceptions from Parallel loops.

588. Use PLINQ to parallelize a CPU-bound query.

589. Compare PLINQ with ordinary LINQ for different data sizes.

590. Create a parallel pipeline with producer and consumer stages.

591. Implement a work-stealing-like queue for educational purposes.

592. Implement a thread-safe object pool.

593. Create a concurrent statistics aggregator.

594. Build a thread-safe in-memory cache.

595. Build a cache with stampede protection.

596. Implement per-key locking for cache refresh.

597. Build a concurrent rate limiter using sliding windows.

598. Create a deduplication service safe under concurrent requests.

599. Design an idempotent operation processor under concurrency.

600. Simulate concurrent order updates and prevent lost updates.

601. Create a thread-safe sequence generator.

602. Detect and diagnose a deadlock from a supplied code sample.

603. Detect and diagnose a livelock from a supplied code sample.

604. Detect and diagnose thread-pool starvation in a sample program.

## 13. Memory, GC, Span, Memory & Performance

605. Write a program that demonstrates stack versus heap allocation conceptually.

606. Demonstrate value-type copying versus reference-type aliasing.

607. Measure allocations caused by string concatenation.

608. Reduce allocations in a hot string-building loop.

609. Demonstrate boxing and unboxing overhead.

610. Refactor a boxed numeric loop to avoid boxing.

611. Demonstrate interface dispatch on value types and boxing implications.

612. Use readonly struct for a small value type.

613. Use ref returns in a small performance-oriented example.

614. Use ref locals to modify an array element efficiently.

615. Use in parameters for readonly reference passing.

616. Use scoped/ref-safe patterns correctly in modern C#.

617. Use Span<T> to process a slice of an array without allocation.

618. Write a Span-based parser for integers.

619. Write a ReadOnlySpan<char>-based tokenizer.

620. Use stackalloc safely for small fixed-size buffers.

621. Compare stackalloc with heap allocation for a small buffer.

622. Use Memory<T> in an async method.

623. Demonstrate why Span<T> cannot cross an await boundary.

624. Use ArrayPool<T> to reduce temporary array allocations.

625. Return rented arrays safely from a helper.

626. Build a reusable buffer manager with ArrayPool<T>.

627. Use ValueStringBuilder-like techniques for low-allocation formatting.

628. Use CollectionsMarshal.GetValueRefOrAddDefault in an optimization exercise.

629. Measure dictionary lookup versus linear search for different sizes.

630. Measure List<T> growth and capacity effects.

631. Pre-size a List<T> and compare allocations.

632. Compare foreach over arrays, lists, and IEnumerable<T>.

633. Measure the overhead of iterator/yield-based pipelines.

634. Show how LINQ can allocate in a hot path and refactor it.

635. Create a zero-allocation-ish loop for processing a Span<int>.

636. Compare StringBuilder and interpolated strings for different workloads.

637. Use string.Create for custom formatted output.

638. Use interpolated string handlers in a practical logging helper.

639. Implement a custom interpolated string handler.

640. Measure closure allocations from lambdas.

641. Refactor a lambda-heavy hot loop to reduce allocations.

642. Measure async state-machine overhead with a microbenchmark.

643. Compare Task and ValueTask in an appropriate scenario.

644. Create a ValueTask-returning method that completes synchronously most of the time.

645. Explain when ValueTask should not be used and demonstrate an anti-pattern.

646. Use GC.GetAllocatedBytesForCurrentThread in a benchmark exercise.

647. Use GC.GetTotalMemory to compare allocations.

648. Create a program that forces garbage collections and observes generations.

649. Show a Gen0-heavy workload and reduce temporary allocations.

650. Demonstrate LOH allocation with large arrays.

651. Demonstrate object pooling for a high-allocation workload.

652. Create a benchmark project with BenchmarkDotNet and compare two implementations.

653. Profile a deliberately slow C# method and identify allocation hotspots.

654. Refactor a CPU and allocation hot path after measuring baseline performance.

## 14. File I/O, Serialization, Streams & Networking Basics

655. Read a text file line by line.

656. Write lines to a text file asynchronously.

657. Copy a large file using buffered streams.

658. Count lines, words, and characters in a file.

659. Find the largest file in a directory tree.

660. Find all files matching a pattern recursively.

661. Monitor a directory using FileSystemWatcher.

662. Handle duplicate FileSystemWatcher events safely.

663. Build a CSV reader using StreamReader.

664. Build a CSV writer using StreamWriter.

665. Serialize an object to JSON using System.Text.Json.

666. Deserialize JSON into a typed record.

667. Configure JsonSerializerOptions for case-insensitive property names.

668. Handle enum serialization in System.Text.Json.

669. Create custom JSON property naming behavior.

670. Create a JsonConverter for a custom type.

671. Create a JsonConverter for a polymorphic hierarchy.

672. Stream JSON records from a large file without loading the entire file.

673. Write JSON records incrementally to a stream.

674. Handle malformed JSON records in a batch.

675. Serialize a circular object graph safely.

676. Implement a custom serialization format for a simple object.

677. Read and write binary data using BinaryReader/BinaryWriter.

678. Write a simple length-prefixed binary protocol.

679. Implement CRC/checksum validation for a simple payload.

680. Compress a stream using GZipStream.

681. Decompress a GZip stream asynchronously.

682. Encrypt a file stream using a modern symmetric cryptography API.

683. Decrypt a file stream and validate integrity.

684. Build a file-copy API that reports progress.

685. Implement resumable file copying.

686. Implement chunked file upload logic.

687. Implement a checksum-based duplicate-file detector.

688. Watch for a file and process it exactly once.

689. Implement atomic file replacement using a temporary file.

690. Implement a safe configuration file reload when the file changes.

691. Create a TCP echo server.

692. Create a TCP echo client.

693. Implement message framing over TCP.

694. Implement length-prefix framing over a NetworkStream.

695. Implement a simple UDP sender/receiver.

696. Create an HttpClient GET request with cancellation.

697. Create an HttpClient POST request with JSON.

698. Configure HttpClient reuse correctly with IHttpClientFactory-style concepts.

699. Implement a typed HTTP client abstraction.

700. Implement HTTP retry logic that respects idempotency.

701. Implement an HTTP timeout and cancellation policy.

702. Stream a large HTTP response without buffering.

703. Upload a file using multipart/form-data.

704. Build a small health-check client that reports latency and errors.

705. Review a network/file I/O implementation for blocking and resource leaks.

## 15. Dependency Injection, Configuration & Application Architecture

706. Build a console application using constructor dependency injection.

707. Create an interface for a clock and inject it for testability.

708. Create an interface for a random-number generator and inject it.

709. Create scoped, transient, and singleton service examples.

710. Demonstrate lifetime mismatch problems.

711. Create a service that consumes a scoped dependency safely.

712. Build options classes for configuration.

713. Bind configuration values into strongly typed options.

714. Validate options at startup.

715. Implement named configuration sections.

716. Create an environment-specific configuration loader.

717. Implement feature flags using configuration.

718. Build a service decorator using dependency injection.

719. Register multiple implementations of the same interface.

720. Resolve all implementations and select one by key.

721. Implement keyed-service selection without a third-party library.

722. Create an abstract factory over registered services.

723. Create a generic factory service.

724. Implement a small command bus using DI.

725. Implement a query handler pattern.

726. Create pipeline behaviors around handlers.

727. Add logging behavior to a handler pipeline.

728. Add validation behavior to a handler pipeline.

729. Add transaction behavior to a handler pipeline.

730. Add retry behavior to a handler pipeline.

731. Create a background worker using BackgroundService concepts.

732. Build a hosted-service-style scheduler.

733. Implement graceful shutdown for a hosted worker.

734. Create a health-check abstraction.

735. Create a metrics collector abstraction.

736. Build a configuration reloader.

737. Create a simple service locator and explain why it is a design smell.

738. Refactor service-locator code into constructor injection.

739. Refactor a static utility dependency into an injected abstraction.

740. Separate domain logic from infrastructure dependencies.

741. Separate pure logic from I/O-heavy orchestration.

742. Design a modular application structure for a medium C# service.

743. Create an application service over domain objects.

744. Implement the repository pattern and discuss when it adds value.

745. Implement a unit-of-work abstraction and explain transaction boundaries.

746. Create a specification-based query abstraction.

747. Create a domain service when behavior does not naturally fit an entity.

748. Model aggregate boundaries for an order workflow.

749. Create immutable command/request DTOs using records.

750. Create immutable response DTOs.

751. Design a plugin-based application architecture.

752. Design a feature-toggle architecture with local and remote providers.

753. Create a fallback chain for multiple service implementations.

754. Create a configurable policy pipeline.

755. Review an over-engineered architecture and simplify it.

## 16. Unit Testing, Mocking & Testability

756. Write unit tests for a calculator class.

757. Write parameterized tests for numeric edge cases.

758. Test a method that throws ArgumentNullException.

759. Test a custom validation exception.

760. Test an immutable value object for equality.

761. Test a class that depends on an injected clock.

762. Test a service with a mock repository.

763. Test a service with multiple repository calls.

764. Verify that a dependency method is called with specific arguments.

765. Verify that a dependency is not called on validation failure.

766. Test asynchronous service methods.

767. Test cancellation behavior.

768. Test timeout behavior.

769. Test retry logic without making real network calls.

770. Test a circuit breaker state transition.

771. Test an in-memory cache.

772. Test cache expiration with an injected clock.

773. Test a producer-consumer component deterministically.

774. Test a thread-safe component under concurrent access.

775. Write property-based-style tests manually for an algorithm.

776. Write tests for a parser with valid and invalid inputs.

777. Write tests for CSV quoting edge cases.

778. Write tests for JSON serialization round trips.

779. Write tests for custom JsonConverter behavior.

780. Write tests for an expression-based filter.

781. Write tests for a LINQ transformation pipeline.

782. Write tests for a repository that should not call the database on invalid input.

783. Write tests for a domain aggregate and state transitions.

784. Test idempotency for duplicate commands.

785. Test optimistic concurrency handling.

786. Test retry exhaustion behavior.

787. Test transient versus fatal exception handling.

788. Test logging through an injected logger abstraction.

789. Assert structured logging properties.

790. Write a test for a race-prone counter and make it deterministic.

791. Create a reusable test data builder.

792. Create object mothers/builders for domain test data.

793. Generate randomized test data safely.

794. Write a custom test helper for asserting collections.

795. Write a custom assertion for Result<T>.

796. Test a background worker with a fake dependency.

797. Test graceful shutdown of a worker.

798. Test a timer-driven service without waiting in real time.

799. Introduce an injectable scheduler abstraction and test it.

800. Test an HTTP client with a fake HttpMessageHandler.

801. Test retry behavior with a sequence of fake HTTP responses.

802. Test a file-processing service using an abstract filesystem.

803. Test a service without static calls by introducing abstractions.

804. Refactor untestable code and add a test suite.

805. Identify flaky test causes in a concurrent test suite.

806. Design a fast unit-test suite and separate slower integration tests.

## 17. C# Modern Language Features & Source-Oriented Coding

807. Rewrite a switch statement as a switch expression.

808. Use relational and logical patterns to classify numeric ranges.

809. Use property patterns to validate an object.

810. Use positional patterns with records.

811. Use list patterns to match array shapes.

812. Use raw string literals for a multi-line JSON-like value.

813. Use target-typed new in a clean example.

814. Use target-typed conditional expressions.

815. Use global using directives in a project.

816. Use file-scoped namespaces.

817. Use init-only setters to create immutable configuration.

818. Use required members for construction-time validation.

819. Use record with with-expression for non-destructive mutation.

820. Use record struct for a small value object.

821. Use primary constructors in a practical service/class example.

822. Refactor a class into a record where value semantics are appropriate.

823. Use collection expressions to simplify array/list initialization.

824. Use spread elements in collection expressions.

825. Use null-coalescing assignment for lazy initialization.

826. Use null-conditional operators safely in nested object access.

827. Use static abstract interface members for generic numeric operations.

828. Create a generic math-like abstraction using static abstract interface members.

829. Use generic type constraints with modern interface capabilities.

830. Build a type-safe parser interface using generic math.

831. Use raw string literals for a regular expression pattern.

832. Use interpolated string handlers in a custom logger.

833. Build a custom logging interpolated string handler.

834. Use ref structs in a safe parser implementation.

835. Create a ref readonly API for a performance-sensitive value type.

836. Use scoped ref behavior safely in a modern C# API.

837. Use required and init together for immutable commands.

838. Use primary constructors with dependency injection-style classes.

839. Refactor verbose constructor/property code using primary constructors.

840. Use list patterns to validate command formats.

841. Use switch expressions with exhaustive handling for domain states.

842. Use discriminated-union-like modeling with records and pattern matching.

843. Create an error model using sealed records and pattern matching.

844. Use file-local types to keep implementation details private.

845. Create a local function for a small recursive algorithm.

846. Use static local functions to avoid closure capture.

847. Use anonymous functions with explicit parameter types when needed.

848. Use function pointers in an advanced unsafe example.

849. Demonstrate checked user-defined operators in a value type.

850. Implement operator overloads for a Money type.

851. Implement implicit/explicit operators carefully for a value type.

852. Use index and range operators in practical array/string code.

853. Use default interface methods in an extensible abstraction.

854. Create a versioning-friendly interface with default implementation.

855. Compare class, record class, struct, record struct, and readonly struct for a domain type.

856. Refactor a C# 7-era implementation into modern idiomatic C#.

857. Review a modern C# solution for readability and language-feature overuse.

## 18. Unsafe, Interop & Advanced Runtime Exercises

858. Write an unsafe method that iterates over an int buffer with pointers.

859. Pin a managed array and access it through a pointer.

860. Compare pointer iteration with Span iteration.

861. Implement a simple unmanaged buffer wrapper.

862. Allocate and free unmanaged memory using native allocation APIs.

863. Copy bytes between managed and unmanaged memory.

864. Convert a managed string to unmanaged memory safely and release it.

865. Call a simple native library function via P/Invoke.

866. Define a P/Invoke struct with correct packing.

867. Marshal a native struct to a managed struct.

868. Marshal a UTF-8 string across a native boundary.

869. Handle a native function returning an error code.

870. Wrap a native handle in SafeHandle.

871. Build a native callback and marshal it as a delegate.

872. Keep a callback delegate alive correctly.

873. Create a small native interop abstraction isolated behind an interface.

874. Use MemoryMarshal to reinterpret compatible memory safely.

875. Use BinaryPrimitives to read/write integers in specific endianness.

876. Implement a network byte-order parser using BinaryPrimitives.

877. Implement a custom binary protocol parser using Span<byte>.

878. Build a zero-copy parser for a fixed binary message.

879. Use SequenceReader<byte> to parse a segmented byte sequence.

880. Parse a protocol containing length-prefixed fields.

881. Parse a protocol containing variable-length integers.

882. Implement a varint encoder/decoder.

883. Implement a CRC32-like checksum for a protocol exercise.

884. Build a minimal framing protocol over Pipelines-like abstractions.

885. Use System.IO.Pipelines for a producer-consumer parser.

886. Build a line-oriented parser over PipeReader.

887. Write a PipeWriter producer with backpressure.

888. Implement a custom MemoryPool<byte> usage scenario.

889. Implement a custom ReadOnlySequence traversal.

890. Parse a multi-segment buffer without copying.

891. Demonstrate how pinning can affect GC performance.

892. Create a benchmark comparing copy-based and zero-copy parsing.

893. Use stackalloc with variable length carefully and safely.

894. Explain and demonstrate unsafe code risks.

895. Audit a provided unsafe block for memory-safety bugs.

896. Fix an incorrect P/Invoke declaration.

897. Diagnose a native memory leak in a wrapper.

898. Create a finalizer-backed native resource wrapper and then refactor it to SafeHandle.

899. Use Marshal.SizeOf and Unsafe.SizeOf and compare semantics.

900. Inspect field layout using StructLayout.

901. Demonstrate explicit versus sequential struct layout.

902. Create a blittable struct and verify its layout.

903. Measure serialization cost of blittable versus non-blittable data.

904. Write a custom UTF-8 decoder using spans for educational purposes.

905. Build a custom high-performance hex encoder.

906. Build a custom Base64-like encoder exercise using spans.

907. Review an unsafe performance optimization and determine whether it is actually beneficial.

## 19. Distributed Systems, Reliability & Production-Grade C#

908. Implement an idempotency-key store for command processing.

909. Create an idempotent payment command handler.

910. Implement optimistic concurrency with a version number.

911. Implement compare-and-swap style update logic.

912. Build a retry policy that distinguishes HTTP 408, 429, 5xx, and non-retryable 4xx responses.

913. Implement exponential backoff with decorrelated jitter.

914. Implement a token-bucket rate limiter.

915. Implement a leaky-bucket rate limiter.

916. Implement a sliding-window rate limiter.

917. Implement per-user rate limiting.

918. Implement per-IP rate limiting.

919. Implement request deduplication for concurrent identical requests.

920. Implement single-flight cache refresh semantics.

921. Build a resilient in-memory cache with stale-while-revalidate behavior.

922. Implement cache-aside with stampede protection.

923. Implement write-through cache semantics in a simplified service.

924. Implement write-behind semantics with a background worker.

925. Build a circuit breaker with closed, open, and half-open states.

926. Add metrics to a circuit breaker.

927. Add structured logging to a retry pipeline.

928. Propagate correlation IDs through async operations.

929. Build a request context object that is immutable and safe to pass across layers.

930. Implement an outbox-like queue using a local database abstraction.

931. Implement an inbox/deduplication consumer.

932. Create an eventual-consistency simulator for an order workflow.

933. Simulate duplicate message delivery and make a consumer idempotent.

934. Simulate out-of-order event delivery and reorder events by sequence number.

935. Implement a simple event store in memory.

936. Replay events to rebuild aggregate state.

937. Implement snapshotting for a long event stream.

938. Build an event version-upgrader for old payload shapes.

939. Implement dead-letter handling for poison messages.

940. Implement retry queues with scheduled visibility.

941. Build a delayed-job queue using timestamps.

942. Implement a bounded worker pool with backpressure.

943. Implement graceful shutdown while draining queued work.

944. Implement leader-election-like behavior for a single-process educational scenario.

945. Implement a lease with expiration and renewal.

946. Implement a distributed-lock-like abstraction with an injected store.

947. Handle clock skew considerations in lease expiration logic.

948. Build a health model that distinguishes liveness and readiness.

949. Implement a dependency health aggregator.

950. Implement a bulkhead isolation pattern.

951. Combine timeout, retry, circuit breaker, and bulkhead into one policy pipeline.

952. Design a safe retry policy for non-idempotent operations.

953. Implement request deadlines that propagate through nested calls.

954. Build a failure-injection test harness for a service.

955. Create chaos-style tests for transient failures in an in-memory system.

956. Design and implement a resilient batch processor that can resume after process restart.

957. Review a production service for resilience anti-patterns and refactor it.

## 20. Senior/Lead (5-8 Years): Architecture, Diagnostics, Coding & System Scenarios

958. Design and implement a modular C# application that supports feature-based modules loaded at startup.

959. Refactor a 2,000-line service class into cohesive components without changing public behavior.

960. Take a tightly coupled legacy class and introduce seams for testing.

961. Design a plugin architecture with versioned contracts.

962. Implement API version negotiation at the service layer.

963. Design a backwards-compatible DTO evolution strategy and implement sample converters.

964. Build a command pipeline supporting validation, authorization, retries, logging, and metrics.

965. Build a query pipeline supporting filtering, sorting, pagination, and projection.

966. Implement a transaction boundary around a multi-step business operation.

967. Implement a saga-style workflow in memory with compensating actions.

968. Create a state-machine engine for an order lifecycle.

969. Build a generic finite state machine with guarded transitions.

970. Implement optimistic concurrency with retry and conflict resolution.

971. Implement pessimistic concurrency with lock ownership and expiration.

972. Build a scheduler supporting delayed jobs and retry policies.

973. Build a priority scheduler with starvation prevention.

974. Create a work-stealing-style executor and benchmark it.

975. Build a bounded asynchronous pipeline with backpressure and cancellation.

976. Implement adaptive concurrency based on observed latency.

977. Implement load-shedding when queue depth exceeds a threshold.

978. Build a bulkhead around an unreliable dependency.

979. Implement an adaptive timeout based on historical latency percentiles.

980. Build a circuit breaker that supports probe traffic in half-open state.

981. Create a request sampler that keeps a percentage of traces while always sampling errors.

982. Implement structured diagnostic context propagation across asynchronous tasks.

983. Implement a correlation and causation ID model for events.

984. Build a lightweight event bus with synchronous and asynchronous handlers.

985. Implement ordered event processing per aggregate while allowing cross-aggregate concurrency.

986. Implement partitioned consumers using consistent routing by key.

987. Build a replayable event processing pipeline.

988. Implement an event versioning strategy with upcasters.

989. Build a snapshotting mechanism and verify replay equivalence.

990. Implement an audit log that captures before/after state safely.

991. Design a secret-safe logging policy and implement a redaction helper.

992. Implement PII field redaction based on attributes.

993. Build a configuration provider chain with environment, file, and remote precedence.

994. Create a dynamic feature-flag evaluator with rollout percentages.

995. Implement a canary decision function based on user and tenant keys.

996. Build a multi-tenant cache with isolation and eviction.

997. Implement tenant-aware throttling.

998. Implement quota accounting with atomic updates.

999. Build a per-tenant concurrency limiter.

1000. Design an in-memory authorization engine with policies and claims.

---

## Suggested interview progression

| Experience | Focus | Suggested question range |
|---|---|---:|
| 0–1 year | Syntax, strings, arrays, OOP, exceptions, collections, basic LINQ | 1–400 |
| 1–3 years | LINQ, generics, delegates, async/await, DI, testing, files, JSON | 350–700 |
| 3–5 years | Concurrency, performance, expression trees, runtime behavior, architecture | 600–850 |
| 5–8 years | Reliability, production diagnostics, advanced performance, Roslyn, architecture | 750–1000 |

## Interviewer challenge mode

- Implement first; explain second.
- Add 3–5 edge cases before considering the solution complete.
- State complexity before optimizing.
- For concurrent code, identify shared state, synchronization, cancellation, and failure modes.
- For production scenarios, discuss observability, resilience, idempotency, and operational recovery.
